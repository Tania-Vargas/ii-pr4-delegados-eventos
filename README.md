# Práctica 4 - Eventos. Delegados

### Ejercicio 1
Se han creado un cubo y un cilindro, junto con prefabs para las esferas de tipo 1 y tipo 2. La funcionalidad básica de cada uno se implementa de la siguiente forma:
- **Cubo**: Se ha creado como un `GameObject` simple, al que se le ha asignado un script llamado *ej1_cube_move*. Este script permite el movimiento del cubo mediante las teclas *W, A, S* y *D*, usando `GetKey` para detectar el input y `Translate` para mover el cubo. No se utiliza Rigidbody, ya que no se requiere interacción física avanzada en su movimiento.
- **Cilindro**: El cilindro es un `Rigidbody` con los ejes de movimiento y rotación congelados, ya que no necesita desplazarse. Su rol principal es detectar la colisión con el cubo. Para ello, se le ha asignado el script *ej1_notificador*, que lanza el evento `OnChoqueCilindro` al detectar la colisión con un objeto que tenga la etiqueta "cubo".
![Ejercicio 1](./gif/ii-pr4-ej1.gif)

### Ejercicio 2
...
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
