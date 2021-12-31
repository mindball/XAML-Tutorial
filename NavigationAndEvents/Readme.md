

## UserControls
```
User controls are UIElements and that can have parents and children
It is used inm order to group several UIElements together in a logical manner
```

## Pages
```
In order to navigate from one view to another we need to make use of Pages
Pages are also UIElements that can have parents and children
Parent of a page is a Frame, this is because we need navigate from one page to another
```
> Similar to window a Page holds content
> Ability to be navigated to and hosted by:
* Frame
* navigationWindows
* Windows Internet Explorer

### Lifetime maanagement
> KeepAlive
```
Boolean value whis implies whether a Page is save in navigation history:
Basically mean that you can never get back to this page if you press the back button
```
> NavigationService
```
The object that the host of the page is using to manage navigation, this then allows us 
to navigate from one page to another, which is very useful, has the ability to navigate forward
and backwards, and where going to see how to do that
```
## Navigation 
```
In order for navigation to work both user controls must be owned by a Page
```