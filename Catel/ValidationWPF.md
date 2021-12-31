# Data Validation and Error Reporting
```
Your view model or model will often be required to perform data validation and to signal 
any data validation errors to the view so that the user can act to correct them.
Silverlight and WPF provide support for managing data validation errors that occur when 
changing individual properties that are bound to controls in the view. For single properties
that are data-bound to a control, the view model or model can signal a data validation error
within the property setter by rejecting an incoming bad value and throwing an exception. 
If the ValidatesOnExceptions property on the data binding is true, the data binding engine
in WPF and Silverlight will handle the exception and display a visual cue to the user that
there is a data validation error.

However, throwing exceptions with properties in this way should be avoided where possible. 
An alternative approach is to implement the IDataErrorInfo or INotifyDataErrorInfo interfaces 
on your view model or model classes. These interfaces allow your view model or model to 
perform data validation for one or more property values and to return an error message to 
the view so that the user can be notified of the error.
```
## IDataErrorInfo

## INotifyDataErrorInfo

## ValidationRule