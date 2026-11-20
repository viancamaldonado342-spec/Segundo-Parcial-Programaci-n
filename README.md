# Cafetería El Buen Sabor - Pedidos

## Datos del estudiante

- **Nombre:** Vianca Liza Maldonado Mejía
- **Matrícula:** 2025-3294

## Descripción del programa

Aplicación de escritorio desarrollada en C# con Windows Forms para registrar pedidos de la cafetería **El Buen Sabor**. Permite introducir los datos del cliente y de cada producto, agregar líneas al pedido y calcular los importes correspondientes, incluyendo descuento por cliente frecuente, empaque para pedidos para llevar e ITBIS.

## Datos de entrada

- Nombre del cliente.
- Fecha del pedido.
- Indicación de si el cliente es frecuente.
- Nombre y precio del producto.
- Cantidad del producto (de 1 a 20).
- Tamaño normal o grande.
- Indicación de si el producto lleva porción extra.
- Servicio en local o para llevar.

### Precios de referencia para las pruebas

| Producto | Precio (RD$) |
|---|---:|
| Café americano | 75.00 |
| Sándwich | 180.00 |
| Jugo | 120.00 |
| Pastelito | 60.00 |
| Batida | 150.00 |

El nombre y el precio se introducen en el formulario; los productos no se seleccionan de una lista.

## Proceso

1. Se calcula el precio unitario sumando RD$25.00 si el tamaño es grande y RD$30.00 si lleva porción extra.
2. Se calcula el total de cada línea multiplicando el precio unitario por la cantidad.
3. Se acumulan los totales de las líneas para obtener el subtotal.
4. Si el cliente es frecuente, se aplica un descuento del 10 % del subtotal.
5. Si el servicio es para llevar, se agrega RD$20.00 de empaque una sola vez por pedido.
6. Se calcula la base imponible: subtotal menos descuento más empaque.
7. Se calcula el ITBIS del 18 % sobre la base imponible.
8. Se obtiene el total a pagar sumando la base imponible y el ITBIS.

## Salida

El programa muestra las líneas agregadas al pedido con la cantidad, el producto y su opción (tamaño o porción extra), el precio unitario y el total de la línea. También muestra el subtotal, el descuento, el empaque, el ITBIS y el total a pagar, expresados en pesos dominicanos (RD$).

## Caso de prueba

- **Cliente:** María Pérez (frecuente).
- **Producto 1:** Sándwich, precio RD$180.00, cantidad 2, tamaño grande.
- **Producto 2:** Jugo, precio RD$120.00, cantidad 1, con porción extra.
- **Servicio:** Para llevar.

### Resultado esperado

| Concepto | Importe (RD$) |
|---|---:|
| Subtotal | 560.00 |
| Descuento | 56.00 |
| Empaque | 20.00 |
| Base imponible | 524.00 |
| ITBIS (18 %) | 94.32 |
| **Total a pagar** | **618.32** |

## Capturas de pantalla

Agrega aquí capturas del programa en ejecución, incluyendo el formulario con el caso de prueba y los resultados calculados.

<!-- Inserta las imágenes en el repositorio y enlázalas, por ejemplo:
![Formulario de pedidos](capturas/formulario-pedidos.png)
-->

## Repositorio

**Enlace de GitHub:** [Agregar aquí el enlace al repositorio]


