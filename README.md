# VisualStudio_PJ
使用visual studio开发，C/C++,C#等，_PJ表示_project







# visual studio快捷键



## 注释

 注释： 先CTRL+K，然后CTRL+C
取消注释： 先CTRL+K，然后CTRL+U

## 代码格式化

Ctrl + K ,  Ctrl + D.  自动整理代码

## 转到定义及返回

F12，转到定义处。

shift + F12 ,返回之前的位置。







# visual studio 2022入门



打开 VS2022，可以看到如下界面：

选择【继续但无需代码（W）】

在菜单中依次选择“文件->新建->项目”，在弹出的如下窗口中语言选择C++。

选择空项目（使用适用于Windows的从头开始操作，不提供基础文件）

下一步

配置项目，项目名称，存放路径等。

创建完成后，可以在【解决方案资源管理器】里看到整个项目。（解决方案管理器在菜单栏【视图】中第一个）

在 “源文件” 处右击鼠标，弹出的菜单中选择 “添加 --> 新建项”



## 控制台转窗口应用

- 设置路径: 项目——项目属性——配置属性——链接器——系统——（右边）子系统





## 第一个问题：sprintf

在VS 2019中编译 C++ 语言项目，如果使用了 sprintf函数，编译时便会提示如下错误：

 error C4996: 'sprintf': This function or variable may be unsafe. Consider using sprintf_s instead. To disable deprecation, use _CRT_SECURE_NO_WARNINGS. See online help for details. 


原因分析：

原因是Visual C++ 2022 使用了更加安全的 run-time library routines 。新的Security CRT functions（就是那些带有“_s”后缀的函数）

原因解释
这种微软的警告，主要因为那些C库的函数，很多函数内部是不进行参数检测的（包括越界类的），微软担心使用这些会造成内存异常，所以就改写了同样功能的函数，改写了的函数进行了参数的检测，使用这些新的函数会更安全和便捷。关于这些改写的函数你不用专门去记忆，因为编译器对于每个函数在给出警告时，都会告诉你相应的安全函数，查看警告信息就可以获知，在使用时也再查看一下MSDN详细了解。库函数改写例子：
mkdir改写为 _mkdir
fopen”改写为 fopen_s
stricmp改写为 stricmp_s
sprintf改写为sprintf_s

strcpy改写为strcpy_s
————————————————
版权声明：本文为CSDN博主「搁浅的渔」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
原文链接：https://blog.csdn.net/qq_36583051/article/details/115076399

解决方案：

**方法一：**将原来的旧函数替换成新的 Security CRT functions  即加上_s后缀

方法二：在文件最开始添加#define _CRT_SECURE_NO_DEPRECATE或#pragma warning(disable:4996) ，这是忽略警告的方法（一般比较少用）。
方法三：干粹在工程属性中设置（推荐）。

在工程属性中设置的方法如下：

对于VC6：
打开Project----settings----Resources----Preprocessor definitions，
添加_CRT_SECURE_NO_DEPRECATE和_SCL_SECURE_NO_DEPRECATE这两个宏。

对于VS系列的版本：
打开项目----项目属性—配置属性----C/C++ ----预处理器----预处理定义，
添加_CRT_SECURE_NO_DEPRECATE和_SCL_SECURE_NO_DEPRECATE这两个宏。
————————————————
版权声明：本文为CSDN博主「搁浅的渔」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
原文链接：https://blog.csdn.net/qq_36583051/article/details/115076399





## 第二问题：C28251 WinMain批注不一致

问题源代码：

```
int WINAPI WinMain(
    HINSTANCE hInstance,      // handle to current instance
    HINSTANCE hPrevInstance,  // handle to previous instance
    LPSTR lpCmdLine,          // command line
    int nCmdShow              // show state
)
```

解决方法：需要_In_ 检测

```
int WINAPI WinMain(
    _In_ HINSTANCE hInstance,      // handle to current instance
    _In_opt_ HINSTANCE hPrevInstance,  // handle to previous instance
    _In_ LPSTR lpCmdLine,          // command line
    _In_ int nCmdShow              // show state
)
```



## C++宽字符类型wchar_t



```
// 创建窗口类
	WNDCLASS wc = {};
	wc.lpfnWndProc = WndProc;
	wc.hInstance = hInstance;
	wc.lpszClassName = L"TimerWindow";
	RegisterClass(&wc);
//
```





## 工具箱控件灰色





## VS 资源视图 - 在另一个编辑器中打开

原因：打开了resource.h

解决方案：

关闭resource.h

重新打开项目

































