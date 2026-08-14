using System;
using System.Diagnostics;
using System.Numerics;

class program
{
    private const int SIZE = 8_000_000;

    static void Main()
    {

        float[] a = new float[SIZE];
        float[] b = new float[SIZE];
        Random rnd = new Random();

        for (int i = 0; i < SIZE; i++)
        {
            a[i] = (float)rnd.NextDouble();
            b[i] = (float)rnd.NextDouble();
        }

        Stopwatch sw = Stopwatch.StartNew();
        float resultadoSecuencial = DotProductSecuencial(a, b);
        sw.Stop();
        Console.WriteLine($"Resultado Secuencial: {resultadoSecuencial}");
        Console.WriteLine($"Tiempo Secuencial: {sw.ElapsedMilliseconds} ms\n");

        sw.Restart();
        float resultadoSIMD = DotProductSIMD(a, b);
        sw.Stop();
        Console.WriteLine($"Resultado SIMD: {resultadoSIMD}");
        Console.WriteLine($"Tiempo SIMD: {sw.ElapsedMilliseconds} ms\n");

        float diferencia = MathF.Abs(resultadoSecuencial - resultadoSIMD);
        Console.WriteLine($"diferencia numerica: {diferencia}");
    }

    static float DotProductSecuencial(float[] a, float[] b)
    {
        float resultado = 0f;
        for (int i = 0; i < a.Length; i++)
        {
            resultado += a[i] * b[i];
        }
        return resultado;
    }

    public static float DotProductSIMD(float[] a, float[] b)

    {
        int vectorSize = Vector<float>.Count;
        int i = 0;
        Vector<float> acumulador = Vector<float>.Zero;
        for (; i <= a.Length - vectorSize; i += vectorSize)
        {
            Vector<float> va = new Vector<float>(a, i);
            Vector<float> vb = new Vector<float>(b, i);
            acumulador += va * vb;
        }

        float resultado = 0.0f;
        for (int j = 0; j < vectorSize; j++)
        {
            resultado += acumulador[j];
        }
        for (; i < a.Length; i++)
        {
            resultado += a[i] * b[i];
        }
        return resultado;
    }
}
    
