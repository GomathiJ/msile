# Wiki Guidelines and Conventions #

This page describes the guidelines and conventions of the wiki.




---


## Content ##

Guidelines and conventions pertaining the content (not the formatting).

### <font size='2'>The Wiki is not Personal</font> ###

The wiki is not a personal space. There should not be "Author: Jimmy".

### <font size='2'>The Wiki is not a Blog</font> ###

This means it is not a space for rants, or how did you spent time finding out how to figure out something.

Instead, the wiki should distill all that trouble someone had in an easy-to-digest format so that poor guy that wrote the wiki is the only one to have trouble, and not the ones reading, too.

_Tell how to do it, not how you did it._

### <font size='2'><a href="http://en.wikipedia.org/wiki/Don't_repeat_yourself">DRY</a> is for Code, not Wikis</font> ###

There is no problem with duplication of small things in a documentation wiki.

If there is more than one page telling how to do or what is something, so be it.

Users are not compilers, they don't know how to find something sometimes, and having it handy in more than one context may help them.

That said... next item:

### <font size='2'>Complex Content Should Have its Page</font> ###

If you need to explain something complex, create a link and explain it in detail in a separate article.

Do not copy paste a lot of things; if you feel the urge to do so, probably it deserves another page.

### <font size='2'><a href="http://en.wikipedia.org/wiki/You_ain't_gonna_need_it">YAGNI</a> is for Code, not Wikis</font> ###

Don't wait for people to ask for documentation. Write it as soon as you can! Nobody will tell you when you need it.

## Formatting ##

Guidelines and conventions pertaining the formatting (not the content).

### <font size='2'>Ugly Markup, But Pretty Page</font> ###

The code for the MainPage uses tables (at least at the present date).

Its markup looks horrible, but it looks good when rendered in the browser, and that's what people will see; it's what should matter.

### <font size='2'>Title at the Top</font> ###

You should put the page's real title (as opposed to the wiki file name, i.e., InternalPageName) as the first and only first-level `=Title=`.

### <font size='2'>Title Casing</font> ###

Please use Title Case (first letter is a capital, and the first letter of any following word except prepositions, articles and conjunctions).

If in doubt (I know I usually am) just capitalize the first letter of any word that looks important to the title.

### <font size='2'>Use HTML When Wiki Markup Fails</font> ###

If something is not working, use [the allowed HTML tags](http://code.google.com/p/support/wiki/WikiSyntax#HTML_support). Most of the time that fixes the problem.

### <font size='2'>Use <code>&lt;font size="2"&gt;</code> for <code>===3rd Level Titles===</code></font> ###

Otherwise they look too much like `==2nd Level Titles==`.

### <font size='2'>Use the Wiki Labels</font> ###

Use relevant wiki labels.

Use at least one (and if possible just one) of EndUsers, Developers WikiDevelopers. Try to see if any fits, in that order (EndUsers are Developers too).

### <font size='2'>Don't Use WikiWords</font> ###

Do not use page names as implicit links, such as MainPage.

Use `[MainPage Main Page]` instead, so it renders as [Main Page](MainPage.md).

Escape PascalCase words with an exclamation mark (`!PascalCased`).

### <font size='2'>Use Page Versioning</font> ###

Refer to [Wiki Versioning](WikiVersioning.md).

### <font size='2'>Try to Achieve a Consistent Style</font> ###

This is easier said than done. But try to make pages look consistent, by re-using common patterns (such as a divider after the Table of Contents).