
# Первое задание
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 

Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

### Код для пользователя
```bash
Circle circle = new Circle(10);
Console.WriteLine($"Площадь круга с радиусом 10 равен - {circle.Square}");

Triangle triangleLength = new Triangle(5, 5, 5);
Console.WriteLine($"Площадь треугольника со сторонами 5х5х5 равен - {triangleLength.Square}, и он " + (triangleLength.isRightTriangle()?"":"НЕ ") + "прямоугольный");

Console.WriteLine("\nДополнительно");
Triangle triangle = new Triangle(new Point(0, 0), new Point(0, 10), new Point(10, 0));
Console.WriteLine($"Площадь треугольника с вершинами (0, 0) (0, 10) (10, 0) равен - {triangle.Square}, и он " + (triangle.isRightTriangle() ? "" : "НЕ ") + "прямоугольный");
			
CustomVerticesFigure customFigure = new CustomVerticesFigure(new Point[] { new Point(0, 0), new Point(0, 10), new Point(10, 0), new Point(10,-10), new Point(-10, -10) });
Console.WriteLine($"Площадь произвольной фигуры равна - {customFigure.Square}");
```

### Пояснения
Сделал через вершины, так как вычисление площади произвольной фигуры по сторонам - не корректно. Фигура может быть как выпуклой, так и "впуклой".

Интерфейс добавил для дальнейшего расширения функционала. Например расчет периметра.


# Второе задание
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

### SQL запрос
```bash
SELECT PR.id, PR.name, CT.name as "category_name" FROM tbl_product as PR
LEFT JOIN tbl_categorylink as LK ON LK.product_id = PR.id
LEFT JOIN tbl_category as CT ON CT.id = LK.category_id;
```

### Пояснения
Раньше с MS SQL не работал. Поэтому пока не знаю его особенностей. Написал простой SQL запрос. 

SQL запросами пользовался для визуализации данных в DataStudio и небольшие правки в бэкэнд.
