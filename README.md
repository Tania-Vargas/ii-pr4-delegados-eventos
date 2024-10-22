# Práctica 4 - Eventos. Delegados

### Ejercicio 1
Se han creado un cubo y un cilindro, junto con prefabs para las esferas de tipo 1 y tipo 2. La funcionalidad básica de cada uno se implementa de la siguiente forma:
- **Cubo**: Se ha creado como un `GameObject` simple, al que se le ha asignado un script llamado *ej1_cube_move*. Este script permite el movimiento del cubo mediante las teclas *W, A, S* y *D*, usando `GetKey` para detectar el input y `Translate` para mover el cubo. No se utiliza Rigidbody, ya que no se requiere interacción física avanzada en su movimiento.
- **Cilindro**: El cilindro es un `Rigidbody` con los ejes de movimiento y rotación congelados, ya que no necesita desplazarse. Su rol principal es detectar la colisión con el cubo. Para ello, se le ha asignado el script *ej1_notificador*, que lanza el evento `OnChoqueCilindro` al detectar la colisión con un objeto que tenga la etiqueta "cubo".
- **Esferas de tipo 1**: Estas esferas se crean como `Rigidbody` para observar su comportamiento en la animación. Se le asigna el script *ej_esfera_t1* en el que se suscriben al evento `OnChoqueCilindro` del cilindro, y al recibir la notificación, se desplazan hacia el cilindro. El movimiento se gestiona en el método `FixedUpdate()`, calculando la dirección hacia el cilindro y moviendo las esferas de forma gradual utilizando `MovePosition`. El movimiento se detiene cuando las esferas están lo suficientemente cerca del cilindro (determinadas por la variable minDistance).
- **Esferas de tipo 2**: La implementación es similar a las esferas de tipo 1, pero en este caso las esferas se desplazan hacia las esferas de tipo 1. En el script *ej1_esferas_t2*, se suscriben también al evento del cilindro y calculan la dirección hacia las esferas de tipo 1 en su método `FixedUpdate()`. El movimiento se detiene cuando la distancia entre ambas esferas es menor que minDistance.

![Ejercicio 1](./gif/ii-pr4-ej1.gif)

### Ejercicio 2
En este ejercicio no se realizaron modificaciones en los scripts existentes. Se descargó un asset de arañas y se replicó la escena anterior con algunas adaptaciones. 
- El cubo fue duplicado, y el cilindro se sustituyó por uno de los prefabs de huevo. A este huevo se le asignó la misma etiqueta que tenía el cilindro en la escena previa, y se le añadió un componente `Rigidbody` con las mismas propiedades, junto con un `Sphere Collider` para asegurar que funcione correctamente.
- En cuanto a las arañas, se siguió un criterio similar. Se eligieron dos prefabs de arañas: uno para reemplazar a las esferas de tipo 1 y otro para las esferas de tipo 2. A ambos prefabs se les asignó un `Rigidbody` con las mismas características utilizadas anteriormente y un `Box Collider`.
- Finalmente, los scripts del ejercicio anterior se aplicaron a los nuevos elementos: el script del notificador se asignó al huevo, el de las esferas de tipo 1 a las arañas verdes, y el de las esferas de tipo 2 a las arañas negras. Se aprovechó el uso de las mismas etiquetas del ejercicio anterior para simplificar la adaptación.

![Ejercicio 2](./gif/ii-pr4-ej2.gif)

### Ejercicio 3
...
![Ejercicio 3](./gif/ii-pr4-ej3.gif)

### Ejercicio 4
...
![Ejercicio 4](./gif/ii-pr4-ej4.gif)

### Ejercicio 5
...
![Ejercicio 5](./gif/ii-pr4-ej5.gif)

### Ejercicio 6
...
![Ejercicio 6](./gif/ii-pr4-ej6.gif)

### Ejercicio 7
...
![Ejercicio 7](./gif/ii-pr4-ej7.gif)

### Ejercicio 8
...
![Ejercicio 8](./gif/ii-pr4-ej8.gif)

### Ejercicio 9
...
![Ejercicio 9](./gif/ii-pr4-ej9.gif)
