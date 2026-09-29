[ ![Universidad de la Laguna](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIDNnYnUBxmifNGRVCluZfrTLSUqit8dv5pg&s) ](https://www.ull.es)

# Práctica 1.1: Movimiento en Unity

Manuel Cadenas García \<[alu0101636849@ull.edu.es](mailto:alu0101636849@ull.edu.es)\>

---
---

### Ejercicio 1: Objeto cambiante de color

El script CambioColor.cs permite darle un color aleatorio a un objeto al inicio y, cada 120 frames, cambiará uno de sus canales de color también aleatoriamente.

Los 120 frames pueden ser cambiados desde el inspector de Unity (atributo público).

Se ha utilizado el método Random.Range() para generar los valores aleatorios de los canales de color.
Se ha utilizado el método GetComponent<Renderer>() para obtener el componente Renderer del objeto y poder cambiar su color.

(Gif)

### Ejercicio 2: Características de Vector3

El script CaracteristicasVector3.cs muestra en el inspector las características de dos Vector3: su magnitud, el ángulo entre ellos, la distancia entre ellos y cuál de ellos tiene mayor altura (eje Y).

Se ha utilizado el método Vector3.Magnitude() para obtener la magnitud de los vectores, el método Vector3.Angle() para obtener el ángulo entre ellos y el método Vector3.Distance() para obtener la distancia entre ellos.

(Gif)

### Ejercicio 3: Texto en pantalla

El script TextoPantalla.cs permite mostrar un texto en pantalla mostrando el valor de la posición de la esfera que tenga como tag "esfera_basica".

Se ha utilizado el método GameObject.FindWithTag() para encontrar el objeto con el tag "esfera_basica" y obtener su posición.

(Gif)

### Ejercicio 4: Distancia entre cilindro y cubo

El script DistanciaCilindroCubo.cs permite calcular la distancia entre un cilindro y un cubo, mostrando el resultado en consola.

Se ha utilizado el método GameObject.Find() para encontrar los objetos por su nombre y el método Vector3.Distance() para calcular la distancia entre ellos.

(Gif)
