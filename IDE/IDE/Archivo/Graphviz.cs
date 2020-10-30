using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using IDE.Archivo;
using System.Diagnostics;


public static class Graphviz
{
    public const string LIB_GVC = @"..\external\gvc.dll";
    public const string LIB_GRAPH = @"..\external\cgraph.dll";
    public const int SUCCESS = 0;

    ///
    /// Creates a new Graphviz context.
    ///
    [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr gvContext();

    ///
    /// Releases a context's resources.
    ///
    [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
    public static extern int gvFreeContext(IntPtr gvc);

    ///
    /// Reads a graph from a string.
    ///
    [DllImport(LIB_GRAPH, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr agmemread(string data);

    ///
    /// Releases the resources used by a graph.
    ///
    [DllImport(LIB_GRAPH, CallingConvention = CallingConvention.Cdecl)]
    public static extern void agclose(IntPtr g);

    ///
    /// Applies a layout to a graph using the given engine.
    ///
    [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
    public static extern int gvLayout(IntPtr gvc, IntPtr g, string engine);

    ///
    /// Releases the resources used by a layout.
    ///
    [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
    public static extern int gvFreeLayout(IntPtr gvc, IntPtr g);

    ///
    /// Renders a graph to a file.
    ///
    [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
    public static extern int gvRenderFilename(IntPtr gvc, IntPtr g,
          string format, string fileName);

    ///
    /// Renders a graph in memory.
    ///
    [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
    public static extern int gvRenderData(IntPtr gvc, IntPtr g,
         string format, out IntPtr result, out int length);

    ///
    /// Release render resources.
    ///
    [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
    public static extern int gvFreeRenderData(IntPtr result);


    public static Image RenderImage(string source, string format)
    {
        // Create a Graphviz context
        IntPtr gvc = gvContext();
        if (gvc == IntPtr.Zero)
            throw new Exception("Failed to create Graphviz context.");

        // Load the DOT data into a graph
        IntPtr g = agmemread(source);
        if (g == IntPtr.Zero)
            throw new Exception("Failed to create graph from source. Check for syntax errors.");

        // Apply a layout
        if (gvLayout(gvc, g, "dot") != SUCCESS)
            throw new Exception("Layout failed.");

        IntPtr result;
        int length;

        // Render the graph
        if (gvRenderData(gvc, g, format, out result, out length) != SUCCESS)
            throw new Exception("Render failed.");

        // Create an array to hold the rendered graph
        byte[] bytes = new byte[length];

        // Copy the image from the IntPtr
        Marshal.Copy(result, bytes, 0, length);

        // Free up the resources
        gvFreeLayout(gvc, g);
        agclose(g);
        gvFreeContext(gvc);
        gvFreeRenderData(result);
        using (MemoryStream stream = new MemoryStream(bytes))
        {
            return Image.FromStream(stream);
        }
    }

    public static void generarArbol(ArrayList nodos)
    {


        //Crear carpeta
        string path = @"..\Arboles Sintacticos";
        string contenido2 = "";
        if (!Directory.Exists(path))
        {
            DirectoryInfo di = Directory.CreateDirectory(path);
        }

        for (int i = 0; i < nodos.Count; i++)
        {
            Nodos nodo = (Nodos)nodos[i];
            for (int j = 0; j < nodo.hijos.Count; j++)
            {
                if (nodo.getPadre().Equals(nodo.hijos[j]))
                {
                    contenido2 += "\"" + nodo.getPadre() + "\"" + "->" + "\"" + nodo.hijos[j] + j + "\"" + ";\n";
                }
                else
                {
                    contenido2 += "\"" + nodo.getPadre() + "\"" + "->" + "\"" + nodo.hijos[j] + "\"" + ";\n";
                }


            }
        }
        String inicio = "digraph G {";
        string contenido1 = "{" +
            "node [margin=0 fontcolor=white fontsize=12 shape=circle style=filled];\n" +
             "}\n";
        String final = "}";

        string graphVizString = inicio + contenido1 + contenido2 + final;
        Console.WriteLine(contenido2);
        Bitmap bm = new Bitmap(Graphviz.RenderImage(graphVizString, "jpg"));
        var imagen = new Bitmap(bm);
        bm.Dispose();
        Image image = (Image)imagen;
        imagen.Save(path + @"\prueba.jpg", ImageFormat.Jpeg);
        imagen.Dispose();
        IDE.ImagenArbol foto = new IDE.ImagenArbol();
        foto.Show();
    }
}