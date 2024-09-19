# ProgramaArray2--PrimerosPasos-

## Descripción del Problema

El objetivo es desarrollar un programa que permita al usuario ingresar dos matrices bidimensionales a través de la consola y luego determine si estas matrices son iguales. Dos matrices se consideran iguales si cumplen las siguientes condiciones:

- **Dimensiones**: Ambas matrices deben tener el mismo número de filas y columnas.
- **Contenido**: Cada elemento en la primera matriz debe coincidir exactamente con el elemento correspondiente en la segunda matriz, es decir, los elementos en las mismas posiciones deben ser idénticos.

## Requisitos del Programa

### Entrada del Usuario

El programa debe solicitar al usuario que ingrese las dimensiones (número de filas y columnas) para cada matriz. Posteriormente, debe permitir al usuario ingresar los valores de cada elemento para ambas matrices.

### Comparación de Matrices

Una vez que ambas matrices han sido ingresadas, el programa debe:

1. Verificar si las matrices tienen el mismo tamaño.
2. Si tienen el mismo tamaño, comparar cada elemento en las dos matrices para asegurarse de que sean idénticos.
3. Finalmente, imprimir un mensaje indicando si las matrices son iguales o no, basándose en la comparación.

## Solución Propuesta

El programa está dividido en varias partes que se encargan de distintos aspectos del problema:

### Ingreso de Datos

- Utiliza la clase `Matriz1` para que el usuario introduzca los valores de la primera matriz.
- Usa la clase `Matriz2` para que el usuario introduzca los valores de la segunda matriz.

### Comparación de Matrices

- La clase `ComparacionMatrices` contiene un método que compara las dos matrices ingresadas. Primero verifica si las matrices tienen las mismas dimensiones. Luego, compara cada elemento de las matrices para determinar si son iguales.
