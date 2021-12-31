# Routed events

## Why Use Routed Events
```
Where routed events become powerful is if you use any of the suggested scenarios: 
defining common handlers at a common root, compositing your own control, 
or defining your own custom control class.
```

## Bubbling events strategy
Bubbling events are essential when:
> Programming navigation enable application
> GUI hierarchy has many layers

## Tunneling events strategy
```
is essentially the opposite of bubbling event
Event travels down from the parent control to its children
Often referred to as Preview events
The parent event will be fired first, followed by the childs event
```
### Useful when:
> Multiple controls inside of one another

## Direct events strategy
```
events tha are raised by a control and handled by that source control itself, they
are the simplest type of routed events. If ClassA is a publisher of the event then
ClassA is also subscriber
```