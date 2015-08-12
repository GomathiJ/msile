# Using FxCop #

This page describes FxCop usage in this project.

You may also want to take a look at [Using StyleCop](UsingStyleCop.md).




---


## Why use FxCop? ##

Because it checks for a lot of errors automatically and we can (almost) ensure very bad code is not being written, without having to worry too much about checking everything ourselves. Also helps cope up with those ignorant beginners (such as me).

## What is FxCop? ##

[Google it](http://lmgtfy.com/?q=what+is+fxcop%3F).

## How do I use it? ##

### <font size='2'>I <b>have</b> Visual Studio 2010 <b>Premium</b> or <b>Professional</b></font> ###

Right click the project in the solution browser and click on "Code Analysis".

### <font size='2'>I <b>don't have</b> Visual Studio 2010 <b>Premium</b> or <b>Professional</b></font> ###

Read [this post](http://www.codeproject.com/Articles/78599/How-to-Use-FxCop).

## What rules are enabled/disabled? ##

**Every rule is to be used, i.e., `Microsoft all rules`.**

## Exceptions ##

You can add exceptions to FxCop for rules that in _**certain specific occasions**_ are wrong. Use the file called `GlobalSuppressions.cs`.

Again, [no rule will be disabled project-wide](#What_rules_are_enabled/disabled?.md).

For justifiable exceptions that will be tolerated (and why), see [FxCop Exceptions](FxCopExceptions.md).