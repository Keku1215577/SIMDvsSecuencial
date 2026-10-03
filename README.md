# SIMD vs. procesamiento secuencial

Proyecto en C# que compara el cálculo de un producto punto mediante una implementación secuencial y una implementación vectorizada con System.Numerics.Vector.

## Objetivo

Evaluar diferencias de rendimiento al procesar millones de elementos mediante dos estrategias de cálculo.

## Funcionamiento

1. Genera dos arreglos de números de punto flotante.
2. Calcula el producto punto de forma secuencial.
3. Calcula el mismo resultado mediante SIMD.
4. Mide el tiempo de ambas ejecuciones.
5. Compara la diferencia numérica.

## Tecnologías

C#, .NET 8, System.Numerics y Stopwatch.

## Conceptos demostrados

- Vectorización SIMD.
- Medición de rendimiento.
- Comparación de algoritmos.
- Operaciones numéricas sobre arreglos.

## Ejecución

Desde la carpeta SIMDvsSECUENCIAL:

dotnet run

## Consideraciones

Los tiempos dependen del procesador y del entorno de ejecución. Las mediciones son experimentales.

## Perfil profesional

Proyecto complementario para demostrar interés en optimización y rendimiento de software.
