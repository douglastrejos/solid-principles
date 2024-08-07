# Principios SOLID ejemplificados PROBLEMA Y SOLUCION

![SOLID Principles](https://miro.medium.com/v2/resize:fit:1400/format:webp/0*pRlsHWFnzN7-k-9-.png)

SOLID es el acrónimo que acuñó **Michael Feathers**, basándose en los principios de la programación orientada a objetos que **Robert C. Martin** había recopilado en el año 2000 en su paper ["_Design Principles and Design Patterns_"](http://www.cvc.uab.es/shared/teach/a21291/temes/object_oriented_design/materials_adicionals/principles_and_patterns.pdf).

Ocho años más tarde, el _tío Bob_ siguió compendiando consejos y buenas prácticas de desarrollo y se convirtió en el padre del código limpio con su célebre libro _'Clean Code'_.

Entre los objetivos de tener en cuenta estos 5 principios a la hora de escribir código encontramos:

- Crear un **software eficaz**: que cumpla con su cometido y que sea **robusto y estable**.
- Escribir un **código limpio y flexible** ante los cambios: que se pueda modificar fácilmente según necesidad, que sea **reutilizable y mantenible**.
- Permitir **escalabilidad**: que acepte ser ampliado con nuevas funcionalidades de manera ágil.

En  este sentido la aplicación de los principios SOLID está muy relacionada con la comprensión y el uso de **patrones de diseño**, que nos permitirán mantener una **alta cohesión** y, por tanto, un **bajo acoplamiento** de software. En definitiva, desarrollar un software de calidad.

El acoplamiento se refiere al **grado de interdependencia que tienen dos unidades de software entre sí**, entendiendo por unidades de software: clases, subtipos, métodos, módulos, funciones, bibliotecas, etc.

Si dos unidades de software son completamente independientes la una de la otra, decimos que están desacopladas.

La cohesión de software es el **grado en que elementos diferentes de un sistema permanecen unidos para alcanzar un mejor resultado** que si trabajaran por separado. Se refiere a la forma en que podemos agrupar diversas unidades de software para crear una unidad mayor.

Los principios SOLID son eso: principios, es decir, **buenas prácticas** que pueden ayudar a escribir un mejor código más limpio, mantenible y escalable.

Como indica el propio Robert C. Martin en su artículo “_Getting a SOLID start_” no se trata de reglas, ni leyes, ni verdades absolutas, sino más bien soluciones de sentido común a problemas comunes. Son heurísticos, basados en la experiencia: “se ha observado que funcionan en muchos casos; pero no hay pruebas de que siempre funcionen, ni de que siempre se deban seguir.”

Dice el _tío Bob_, que SOLID nos ayuda a categorizar lo que es un buen o mal código y es innegable que un código limpio tenderá más a salir airoso del “control de calidad de código WTFs/Minute":

![WTFs/Minute](https://raw.githubusercontent.com/alxgcrz/_principios-SOLID_/main/code/images/code-quality-measurement-WTF.png)

Los 5 principios SOLID son:

1. ==_**S**ingle Responsability Principle (SRP)_ - Principio de Responsabilidad Única==

    Este [principio](https://es.wikipedia.org/wiki/Principio_de_responsabilidad_%C3%BAnica) establece que cada módulo o clase debe tener **responsabilidad sobre una sola parte de la funcionalidad** proporcionada por el software y esta responsabilidad debe estar encapsulada en su totalidad por la clase. Todos sus servicios deben estar estrechamente alineados con esa responsabilidad.

2. ==_**O**pen/Closed Principle (OCP)_ - Principio de Abierto/Cerrado==

    Este [principio](https://es.wikipedia.org/wiki/Principio_de_abierto/cerrado) establece que **«una entidad de software (clase, módulo, función, etc.) debe quedar abierta para su extensión, pero cerrada para su modificación»**. Es decir, se debe poder extender el comportamiento de la entidad pero sin modificar su código fuente.

3. ==_**L**iskov Substitution Principle (LSP)_ - Principio de Substitución de Liskov==

    Este [principo](https://es.wikipedia.org/wiki/Principio_de_sustituci%C3%B3n_de_Liskov) puede definirse como: **«cada clase que hereda de otra puede usarse como su padre sin necesidad de conocer las diferencias entre ellas»**.

4. ==_**I**nterface Segregation Principle (ISP)_ - Principio de Segregación de la Interfaz==

    Este [principio](https://es.wikipedia.org/wiki/Principio_de_segregaci%C3%B3n_de_la_interfaz) establece que los clientes de un programa dado sólo deberían conocer **aquellos métodos del programa que realmente usan, y no aquellos que no necesitan usar**.

5. ==_**D**ependency Inversion Principle (DIP)_ - Principio de Inversión de Dependencias==

    Este [principio]((https://es.wikipedia.org/wiki/Inyecci%C3%B3n_de_dependencias)) consta de dos partes:

    - **Módulos de alto nivel no deben depender de módulos de bajo nivel**. Ambos deben depender de abstracciones.

    - **Abstracciones no deberían depender de detalles**. Los detalles debieran depender de abstracciones.
