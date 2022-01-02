# Dependancy properties
```
So if you want to really go ham on customization and want to really dig deep into 
your user controls and really have full control, basically dependancy properties
will be an important aspect of that.

Are Similar to CLR properties but with extra features
```

## Used extensively throughout WPF
> Height, Width, Background, Foreground etc. are all dependancy properties

## Always static and readonly
```
Static: since it should be available to all controls
readonly 
Readonly: since it`s value should not be change after initialization
```

## Dependancy properties allow you to make:
> Data bindings
> Animations
> Styles
> Triggers
> and more others

## Powerfull feature of Dependancy properties are:
```
Change notifications occurs when certain changes happen to a specific property
Mouse over, size changed and etc.
```

## Defining DP
```
 Using DP as the backing store for "CLR properties". This enables animation, styling, bindings, etc...
 (DP encapsulated CLR properties similar how private field was encapsulate inside CLR Property)
```