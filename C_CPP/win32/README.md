# VisualStudio_PJ
使用visual studio开发，C/C++,C#等，_PJ表示_project







# visual studio快捷键



## 注释

 注释： 先CTRL+K，然后CTRL+C
取消注释： 先CTRL+K，然后CTRL+U

## 代码格式化

Ctrl + K ,  Ctrl + D.  自动整理代码





### 入口点

应用程序代码必须定义适当的入口点：对于控制台应用程序，为 `main` 或 `wmain`，对于 Windows 应用程序，为 `WinMain` 或 `wWinMain`。 有关详细信息，请参阅 [`main` 函数和命令行参数](https://learn.microsoft.com/zh-cn/cpp/cpp/main-function-command-line-args?view=msvc-170)或 [`WinMain` 函数](https://learn.microsoft.com/zh-cn/windows/win32/api/winbase/nf-winbase-winmain)。 若要使用自定义入口点，请指定 [`/ENTRY`（入口点符号）](https://learn.microsoft.com/zh-cn/cpp/build/reference/entry-entry-point-symbol?view=msvc-170)链接器选项。
