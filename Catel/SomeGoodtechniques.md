## How then are WPF applications supposed to handle big operations? 
What if your code involves a large calculation or needs to query a 
database on some remote server? Usually, the answer is to handle the big 
operation in a separate thread, leaving the UI thread free to tend to 
tems in the Dispatcher queue. When the big operation is complete, 
it can report its result back to the UI thread for display.

## DispatcherUnhandledException
```
The DispatcherUnhandledException event handler is passed a DispatcherUnhandledExceptionEventArgs 
argument that contains contextual information regarding the exception, including:
```
> The exception (Exception)
> The Dispatcher from which it originated (Dispatcher).
```
You can use this information to determine whether an exception is recoverable or not. A recoverable exception might be a 
FileNotFoundException, for example, while an unrecoverable exception might be a StackOverflowException, for example.
```