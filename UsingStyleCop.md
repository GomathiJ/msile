# Using StyleCop #

This page describes StyleCop usage in this project.

You may also want to take a look at [Using FxCop](UsingFxCop.md).




---


## Why use StyleCop? ##

Because it checks for a lot of style imperfections automatically and we can (almost) ensure bad code is not being written, without having to worry too much about checking everything ourselves. Also helps cope up with those ignorant beginners (such as me).

## What is StyleCop? ##

[Google it](http://lmgtfy.com/?q=what+is+stylecop%3F).

## How do I use it? ##

First, [download](http://stylecop.codeplex.com/releases) and install.

Then right click the project in the solution browser and click on "Run StyleCop".

## What rules are enabled/disabled? ##

**Every rule is to be used.**

## Exceptions ##

You can add exceptions to StyleCop for rules that in _**certain specific occasions**_ are wrong.

Again, [no rule will be disabled project-wide](#What_rules_are_enabled/disabled?.md).

For justifiable exceptions that will be tolerated (and why), see [StyleCop Exceptions](StyleCopExceptions.md).