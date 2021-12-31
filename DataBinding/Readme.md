# Data binding
```
Data binding can also mean that if an outer representation of the data in an element changes, 
then the underlying data can be automatically updated to reflect the change.
For example, if the user edits the value in a TextBox element, the underlying data value is 
automatically updated to reflect that change.
```
```
Почти всяко едно property в WPF, например button Height, Weight и т.н като
Dependency Property.
Source минава през DB и стига до Target, и чрез DB става комуникацията на 
Source и Target-a
```
```
Ако имамаме дефиниран {Binding Path=} и нямаме дефиниран Source, binding-a ще търси от 
DataContext-a Пример:
```
```csharp

private Car car = new Car("Audi", "A8");
...
this.DataContext = car;
...
<Label>Manuafacture</Label>
<TextBox Text="{Binding Manuafacture}" /> //ako cast-нем (this.DataContext as Car) -> тук достъпваме Model and Manuafacture
Label>Model</Label>
<TextBox Text="{Binding Model}" />
```
## DataContext
```
The DataContext property is the default source of your bindings unless you specifically declare another source, 
like we did in the previous chapter with the ElementName property. There's no default source for the DataContext property 
(it's simply null from the start), but since a DataContext is inherited down through the control hierarchy, 
you can set a DataContext for the Window itself and then use it throughout all of the child controls.
```
## Target
```
Пример TextBox.Text
```

## Source
```
Един нормален C# клас. Примерно POCO
```

## Type of binding
### Two way

### One way

## Dependency Property
```
A Dependency Property is a property whose value depends on the external sources, such as 
animation, data binding, styles, or visual tree inheritance. Not only this, but a 
Dependency Property also has the built-in feature of providing notification when 
the property has changed, data binding and styling.
```
```
The purpose of dependency properties is to provide a way to compute the value of a property 
based on the value of other inputs, such as:
```
> System properties, such as themes and user preference.
> Just-in-time property determination mechanisms, such as data binding and animations/storyboards.
> Multiple-use templates, such as resources and styles.
> Values known through parent-child relationships with other elements in the element tree.
> Self-contained validation.
> Default values.
> Callbacks that monitor changes to other properties.
> A system that can coerce property values based on runtime information.

## The main difference between dependency properties and other CLR properties are listed below
```
CLR properties can directly read/write from the private member of a class by using getter and setter. 
In contrast, dependency properties are not stored in local object.
```
```
Dependency properties are stored in a dictionary of key/value pairs which is provided by the 
DependencyObject class. It also saves a lot of memory because it stores the property when changed. 
It can be bound in XAML as well.
```

## ObservableCollection
```
Всяка колекция, която искаме да се наблюдава за промяна, я wrap-ваме в ObservableCollection
```

## IValueConverter
```c#
public object Convert(object value, Type targetType, object parameter, CultureInfo culture) от кода към UI
public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) от UI към кода
```
### Used cases
> You have a numeric value but you want to show zero values in one way and positive numbers in another way
> You want to check a CheckBox based on a value, but the value is a string like "yes" or "no" instead of a Boolean value
> You have a file size in bytes but you wish to show it as bytes, kilobytes, megabytes or gigabytes based on how big it is