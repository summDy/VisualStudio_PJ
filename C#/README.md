# visual studio快捷键



## 注释

 注释： 先CTRL+K，然后CTRL+C
取消注释： 先CTRL+K，然后CTRL+U

## 代码格式化

Ctrl + K ,  Ctrl + D.  自动整理代码







# C#开发入门



https://developer.aliyun.com/article/993792

看了这边文章，感觉C#很牛逼





## 输出打印



### 使用技巧1

```
var name = "张三"；
var age = 23;
var sex = true;
//获取变量的数据类型
Type t_Name =name.GetType();
Type t_Age = age.GetType();
Type t_Sex =set.GetType();
//打印结果
Console.WriteLine("变量name的类型是{0},变量age的类型是{1},变量sex的类型是{2}",t_Name.ToString(),t_Age.ToString(),t_Sex.ToString());
Console.ReadLine();
```

执行效果：

变量name的类型是System.String，变量age的类型是System.Int32，变量sex的类型是System.Boolean

分析：这段代码主要是看var的应用例子。但也发现Console.WriteLine也类似printf的使用方法。printf中是使用如%d而在Console.WriteLine是｛索引编号｝











## 设置启动时窗口处于屏幕中央

你可以在 Visual Studio 的属性窗口中找到 `StartPosition` 和 `StartPosition` 属性，并将其分别设置为 `Manual` 和屏幕中央的坐标，以便在程序启动时将窗口设置为在屏幕中央启动。

以下是在属性窗口中设置窗口位置的步骤：

1. 选中窗口控件，打开属性窗口。
2. 在属性窗口中找到 `StartPosition` 属性。
3. 将其设置为 `Manual`。
4. 在属性窗口中找到 `Location` 属性。
5. 点击 `...` 按钮，弹出位置编辑器。
6. 在位置编辑器中输入屏幕中央的 x 和 y 坐标。
7. 点击确定以关闭位置编辑器，并保存更改。

这样，你就可以在程序启动时将窗口设置为在屏幕中央启动。请注意，此方法需要手动计算屏幕中央的坐标。





你可以使用以下代码将 C# 程序的窗口设置为在屏幕中央启动：

```
csharpCopy codeprivate void Form1_Load(object sender, EventArgs e)
{
    // 获取屏幕分辨率
    int screenWidth = Screen.PrimaryScreen.Bounds.Width;
    int screenHeight = Screen.PrimaryScreen.Bounds.Height;

    // 计算窗口位置
    int formWidth = this.Width;
    int formHeight = this.Height;
    int x = (screenWidth - formWidth) / 2;
    int y = (screenHeight - formHeight) / 2;

    // 设置窗口位置
    this.StartPosition = FormStartPosition.Manual;
    this.Location = new Point(x, y);
}
```

这段代码将在窗口加载时执行。它使用屏幕的分辨率来计算窗口在屏幕中央的位置，并将窗口的 `StartPosition` 属性设置为 `Manual` 以便手动设置窗口的位置。然后，将窗口的 `Location` 属性设置为计算出的位置。这样就可以在程序启动时将窗口设置为在屏幕中央启动。



## 窗口设置不可伸缩

如果你想让C#窗口的大小固定不可伸缩，可以在窗口加载时设置`FormBorderStyle`属性为`FixedSingle`，这将禁用窗口的最大化和调整大小功能。

你可以在窗口的构造函数中添加以下代码：

```
csharpCopy codepublic Form1()
{
    InitializeComponent();
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
}
```

或者，你也可以在窗口的`Load`事件处理程序中添加以下代码：

```
csharpCopy codeprivate void Form1_Load(object sender, EventArgs e)
{
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
}
```

这将使窗口的大小固定，并且不能通过拖动或最大化按钮进行调整。



你可以在 Visual Studio 的属性窗口中找到 `FormBorderStyle` 属性并将其设置为 `FixedSingle`，这样就可以将窗口的边框样式设置为固定的单一边框，从而禁用窗口的大小调整和最大化功能。

以下是在属性窗口中设置 `FormBorderStyle` 属性的步骤：

1. 选中窗口控件，打开属性窗口。
2. 在属性窗口中找到 `FormBorderStyle` 属性。
3. 将其设置为 `FixedSingle`。

这将使窗口的大小固定，并且不能通过拖动或最大化按钮进行调整。



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





var





















