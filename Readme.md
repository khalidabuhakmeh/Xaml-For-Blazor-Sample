# Xaml For Blazor Sample

This repository has a [Xaml for Blazor sample](https://xaml-for-blazor.com/) to show how to use Silverlight-like Xaml components in your Blazor Wasm applications.

This has been tested in [JetBrains Rider](https://jetbrains.com/rider) on macOS using the .NET 7 SDK.

## Points of Interest

- Xaml Control for Counter: [XamlMadness/XCounter.xaml](XamlMadness/XCounter.xaml)
  - [XamlMadness/XCounter.xaml.cs](XamlMadness/XCounter.xaml.cs)
- Counter ViewModel: [XamlMadness/Models/XCounterViewModel.cs](XamlMadness/Models/XCounterViewModel.cs)
- Project entry using `MSBuild:Compile`: [XamlMadness/XamlMadness.csproj](XamlMadness/XamlMadness.csproj)
- Control Usage in Razor: [XamlMadness/Pages/Counter.razor](XamlMadness/Pages/Counter.razor)

## Initial thoughts

- It's cool that folks can take their Xaml usage and apply it to the web and mix HTML with Xaml output in a single application.
- The resulting HTML produced by Xaml for Blazor may be problematic for accessibility, as it's all `div` elements, including interactive elements such as buttons.
- The Xaml syntax is that of Silverlight, so it's a subset of **WPF**. This can make porting some UI easy to difficult depending on the source.
- When comparing Silverlight components with the abundance of HTML/JS alternatives, is it really worth it?
- This library could benefit from a `BaseViewModel` implementation or the use of Community Toolkit to reduce boilerplate.
- The use of the namespace `System.Windows.Controls` is a mind-trip.

## General Thoughts

Giving folks avenues to upgrade existing systems is a noble effort, especially those stuck in the decay of Silverlight, which grows dimmer by the day. Choosing this particular approach really depends on a team's situation, and whether this is more viable in the long-term than a complete rewrite to a new approach. On a related note, I think it will be harder to find individuals to keep an application built on XAML for the web current and up to date, but maybe that's not the intent here. Maybe the intent is for institutions to squeeze out a little more value for previous investments, and that's OK. Especially when HTML, CSS, JavaScript, and Wasm are next door neighbors in an application's context. Having the two paradigms live side-by-side might make a transition less painful for end users, and keeping users happy is the ultimate goal of why we do _this_.

