[ ![Universidad de la Laguna](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIDNnYnUBxmifNGRVCluZfrTLSUqit8dv5pg&s) ](https://www.ull.es)

# Práctica 7: Realidad Aumentada con Vuforia

Manuel Cadenas García \<[alu0101636849@ull.edu.es](mailto:alu0101636849@ull.edu.es)\>

---
---

### Enunciado
***Realizar una escena de Realidad Aumentada en Unity utilizando el paquete Vuforia Engine. Debes usar algún modelo de la Asset Store e incorporar algún evento.***

### Proyecto

Se importó y configuró el paquete Vuforia Engine. Se toma una `AR Camera` y se añade a la escena vacía.

Modus operandi:
Se crea un `ImageTarget` y se le asigna una imagen de referencia, que se encuentra en la carpeta `Assets/Resources/Images`. Se añade un modelo 3D de la Asset Store como hijo del `ImageTarget`, de modo que aparezca sobre la imagen cuando se detecte.

Para hacerlo más interesante, se tomaron dos modelos 3D de la Asset Store: un dragón y una brujita. Cada uno tendrá como padre un `ImageTarget` distinto, de modo que cada uno se muestre al detectar su imagen correspondiente.

![Gif Ejercicio](./gifs/p7-01.gif)

Y para que sea un poco más dinámico, se añadió un script de `GiroMolon.cs` tanto al dragón como a la brujita, que hace que giren sobre sí mismos, además de un efecto de flotar muy suave.

El script lo que hace es estar desactivado por defecto y se activa cuando el `ImageTarget` es detectado (`OnTargetFound()`), que llama a la función de `IniciarGiro()`, que activa el script. Cuando se pierde la imagen (`OnTargetLost()`), se llama a `PararGiro()`, que desactiva el script. Todo esto para que en `Update()` se haga el giro y el efecto de flotar.

![Gif Ejercicio](./gifs/p7-02.gif)
