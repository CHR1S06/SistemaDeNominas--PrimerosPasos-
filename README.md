# SistemaDeNominas--PrimerosPasos-

# Sistema de Nómina Interactivo en C#

Este repositorio contiene el código para un **sistema de nómina** interactivo que permite a los usuarios ingresar información de empleados, calcular salarios y generar un reporte detallado de la nómina. El sistema fue desarrollado en base al caso de estudio del capítulo 11 del libro "*Aprendiendo a Programar en C#*".

## Descripción del Ejercicio

El objetivo de este ejercicio es desarrollar un sistema de nómina que realice las siguientes tareas:

1. **Captura de información**: Recoger datos del empleado como nombre, salario por hora y horas trabajadas.
2. **Cálculo del salario**: Calcular el salario total de cada empleado basándose en los datos ingresados.
3. **Manejo de múltiples empleados**: Permitir al usuario agregar tantos empleados como desee.
4. **Generación de reporte de nómina**: Mostrar un resumen con los detalles de cada empleado y su salario.

## Estructura del Código

El código está estructurado en varias clases para mantener la modularidad y la claridad del sistema:

### 1. `Empleado`
Esta clase se encarga de almacenar los datos de un empleado, incluyendo:
- Nombre
- Salario por hora
- Horas trabajadas

Además, incluye el método `CalcularSalario()`, que calcula el salario total del empleado.

### 2. `Nomina`
La clase `Nomina` es responsable de gestionar la lista de empleados, permitiendo agregar nuevos y generar un reporte detallado de cada uno.

### 3. `ControladorNomina`
Esta clase maneja la interacción con el usuario. Su responsabilidad es:
- Solicitar la información del empleado.
- Validar la información ingresada.
- Controlar el flujo del programa, como la adición de más empleados.

### 4. `Program`
La clase principal del sistema. Se encarga de iniciar el programa llamando a `ControladorNomina`.

## Interactividad del Sistema

El sistema es completamente interactivo, permitiendo que el usuario:
- **Introduzca manualmente** el nombre, salario por hora y las horas trabajadas de cada empleado.
- **Agregue múltiples empleados**: Después de ingresar los datos de un empleado, el sistema pregunta si se desea añadir otro.
- **Visualice un reporte de nómina** con todos los empleados ingresados y sus salarios calculados.

## Robustez y Control de Errores

El sistema cuenta con varias validaciones para asegurar la robustez y manejo de errores:

1. **Validación de nombre**: Si el usuario ingresa un nombre vacío, se solicita nuevamente hasta que se reciba una entrada válida.
2. **Validación de salario y horas trabajadas**: El sistema utiliza un bloque `try-catch` para asegurar que los valores ingresados sean numéricos. Además, no se permiten valores negativos.
3. **Reingreso en caso de error**: Si se detecta una entrada incorrecta, el usuario es informado del error y se le pide que intente nuevamente.

## Cálculo del Salario

Una vez ingresada la información del empleado, el cálculo del salario se realiza automáticamente. El método `CalcularSalario()` multiplica el salario por hora por las horas trabajadas, y este resultado se muestra en el reporte final.

## Generación de Reporte

El sistema genera un **reporte detallado** que incluye:
- Nombre del empleado
- Salario por hora
- Horas trabajadas
- Salario total calculado

Este reporte se presenta de manera clara y ordenada para que el usuario pueda visualizar fácilmente la nómina de la empresa.

## Conclusión

El sistema de nómina interactivo presentado aquí permite a los usuarios gestionar de manera eficiente la nómina de sus empleados, proporcionando un enfoque modular con un código bien estructurado y robusto. El uso de clases y la separación de responsabilidades permiten que el código sea fácil de mantener y escalar, mientras que las características interactivas hacen que el sistema sea flexible y práctico para el usuario.
