# 
## Remarks
```
Bindings that are TwoWay or OneWayToSource listen for changes in the target 
property and propagate them back to the source. This is known as updating 
the source. Usually, these updates happen whenever the target property 
changes. This is fine for check boxes and other simple controls, but it is 
usually not appropriate for text fields. Updating after every keystroke can 
diminish performance and it denies the user the usual opportunity to backspace 
and fix typing errors before committing to the new value. Therefore, the 
default UpdateSourceTrigger value of the Text property is LostFocus and not 
PropertyChanged.
```