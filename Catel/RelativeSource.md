```c#
<Style TargetType="TextBox">     
      <Style.Triggers>
        <Trigger Property="Validation.HasError" Value="True">
          <Setter Property="Background" Value="Red"/>
          <Setter Property="ToolTip" Value="{Binding RelativeSource={RelativeSource Self},
            Path=(Validation.Errors)[0].ErrorContent}"/>
        </Trigger>
      </Style.Triggers>
```
> Binding RelativeSource={RelativeSource Self}
```
Bind-ва dataSource-a към TargetType в случая TextBox и от там вече имаме достъп до Validation.Errors
```
> Allows for using another XAML element as a binding source instead of the current DataContext.
