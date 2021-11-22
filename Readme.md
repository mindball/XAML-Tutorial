# Intro  Xaml
(insert pic1)
(insert pic2)
(insert pic3)
```
проблема в първият вариант е:
че ще девелопера е длъжен да изпълни implement GUI and Implement behavior
докато при втория дизайнера може да си работи с Implement GUI in XAML, 
a develop-а да си работи back-end - тук имаме Separation of concerns
```


## Code behind
```
Зад всяко едно view имаме определен c# файл(обектите от view модела), 
от което може да взимаме да подаваме данни, евенти
```

## Component base

## behind the scenes
### View <-> ViewModel <-> Model
```
Както и в Asp.net core  MVC actiona-а в дадент контролер, не знае за 
View-то (Framework се ориентира по името на action-a), така и в 
MVVM pattern ViewModel не знае за View, frameworк-а го знаe, обратното е 
че View знае за ViewModel-a (обвързано но е ), тук също така има two way databinding
ViewModel-a като вземе Model-а той си променя properties-тита и след като се променят
те отиват View
```

## Look at framerate lifecycle - CompositionTarget

### CompositionTarget.Rendering
```
можем да му вържем delegate, event, който се вързва към lifecycle на 
```