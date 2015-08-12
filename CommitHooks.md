<table width='100%'><tr><td width='48%' valign='top'>
<h1>Commit Hooks</h1>

This project may use commit hooks to aid in development. Any commit hook used will be explained here; you do not have to use these hooks, but you'll have to do what they do manually.<br>
<br>
If you do not know how to add a commit hook, refer to TortoiseSVN documentation.<br>
<br>
<br>
</td><td width='4%' /><td width='48%' valign='top'>
<h2><font color='red'>Warnings</font></h2>

<ul><li><font color='red'>Do not run these scripts by themselves</font>, or they won't do anything.<b><br>
</li><li></b>Every time you commit code, <font color='red'>use the <code>SVN Commit</code> context menu entry in the solution folder</font>, never in a subfolder, and never in the root directory of the SVN, or the <code>/branches</code> or <code>/tags</code> directories.**<br>
</td></tr></table></li></ul>**


---


## `update-assembly-revision.bat` ##

This is a pre-commit hook.

What this does is to check for whatever `AssemblyInfo.cs` file below your current directory, and update its revision number to **the current revision number + 1**.

If you do not want to run it, before commiting code in the trunk or a branch, update the relevant `AssemblyInfo.cs` file to use **the current SVN revision number + 1** as the **third assembly and file version**.

### <font size='2'>Example</font> ###

This code in the `AssemblyInfo.cs` file:

```cs

[assembly: AssemblyVersion("0.1.123")]
[assembly: AssemblyFileVersion("0.1.123")]```


Will become this:

```cs

[assembly: AssemblyVersion("0.1.124")]
[assembly: AssemblyFileVersion("0.1.124")]```

(This example assumes the current revision number at the time of commit is 123).