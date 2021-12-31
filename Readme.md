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

## Grid
```
Grid-a заема цялото простанство Пример:
 <Grid>
        <Rectangle Fill="Green"></Rectangle>
 </Grid>
 vs
 <Canvas>
        <Rectangle Fill="Green"></Rectangle>
 </Canvas>
```

## Canvas

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

## Good practice
```
Добре е да се ползва когато имам йерархични данни.
```

## Good practice Validation Model-ViewModel
```
Добре е да се валидира и на двете места като в Model е добре да се валидират
някои базисни проверки, докато в ViewModel да се изпълняват по сложни, по-рестриктни.
Друга причина да имплементираме на състоянито на модела вътре в workflow. Например:
Имаме workflow, които по изискване обновява model-а стъпка по стъпка, но модела още на 
първата стъпка не се валидира. Въпреки това, искаме да запазим част от данните на модела,
които потребителя може да използва по късно, по този начин не искам да имплементираме
state-logic в workflow в нашият модел(и ако сме направили подобно нещо е лоша практика).
Тази ф-я при view model validation e добра като практира.

```
```
Добра практика е когато оразмеряваме да го правим в проценти за да може UI да е 
responsible
```
