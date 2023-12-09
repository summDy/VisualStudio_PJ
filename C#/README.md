# visual studio快捷键



## 注释

 注释： 先CTRL+K，然后CTRL+C
取消注释： 先CTRL+K，然后CTRL+U

## 代码格式化

Ctrl + K ,  Ctrl + D.  自动整理代码







# C#开发入门



https://developer.aliyun.com/article/993792

看了这边文章，感觉C#很牛逼





## 语法



### 命名空间命名规则

1. 命名空间名称应使用 PascalCase 大小写规则，即每个单词的第一个字母都大写，不使用下划线或其他分隔符。
2. 命名空间名称应具有描述性，反映其所包含的类型或功能。命名空间名称通常应为一个或多个单词的组合，这些单词反映了它所属的应用程序、模块或库的名称。
3. 命名空间名称可以使用嵌套结构，以分组和组织相关类型。命名空间中的子命名空间应与其父命名空间具有类似的命名规则，以便清楚地表示它们之间的层次结构。

例如，以下是符合命名空间命名规则的示例：

```
namespace MyCompany.MyApplication.MyModule
{
    // ...
}

```

在这个例子中，命名空间名称使用了 PascalCase 大小写规则，具有描述性，反映了它所属的公司、应用程序和模块的名称。它还使用了嵌套结构，以便更好地组织和管理相关类型。



### 类的命名规则



在 C# 中，类的命名规则遵循以下约定：

1. 类名应使用 PascalCase 大小写规则，即每个单词的第一个字母都大写，不使用下划线或其他分隔符。
2. 类名应具有描述性，反映其所表示的实体或对象的名称。类名通常应为一个或多个单词的组合，这些单词反映了它所属的领域、功能或特征。
3. 如果类表示一种抽象概念或接口，则应使用形容词或名词短语作为类名，以便清楚地表示其目的。
4. 如果类表示一种具体的实体或对象，则应使用名词短语作为类名，以便清楚地表示其类型和目的。

例如，以下是符合类命名规则的示例：

```
public class Customer
{
    // ...
}

public class IShape
{
    // ...
}

public class Circle : IShape
{
    // ...
}

```

在这个例子中，类名使用了 PascalCase 大小写规则，具有描述性，反映了它所表示的实体或对象的名称。第二个类名使用了形容词短语作为类名，表示其是一种接口。第三个类名使用了名词短语作为类名，表示其是一种具体的实体类型，并实现了第二个类定义的接口。

### regin

region ：表示区域

`#region` 是 C# 中的一个编译器指令，它允许开发人员在代码中标记一个区域，并将该区域内的代码块折叠起来，以便更好地组织和管理代码。在 Visual Studio 中，`#region` 指令会在代码编辑器中生成一个可折叠的代码块。

`#region` 指令通常用于组织和管理代码，特别是当代码文件非常大时，可以将相关的代码块分组并折叠起来，以便更轻松地浏览和维护代码。此外，`#region` 指令还可以用于注释和解释代码的用途和功能。

以下是 `#region` 指令的语法：

```
#region RegionName
// Code block to be collapsed
#endregion

```

在这个例子中，`RegionName` 是可选的，用于标识代码块的名称。代码块应该包含在 `#region` 和 `#endregion` 之间。

例如，以下是使用 `#region` 指令的示例：

```
#region MyRegion
private void MyMethod()
{
    // Code block to be collapsed
}
#endregion

```

在这个例子中，`#region` 指令标记了一个名为 `MyRegion` 的代码区域，其中包含了一个名为 `MyMethod` 的方法。在 Visual Studio 中，该代码块可以折叠起来，以便更好地组织和管理代码。







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



## 菜单栏添加菜单项弹出的窗口

【文件】——【新建】——【文件】

Options.cs

注意：

如果Options类不继承Form则不会出现设计器

创建的文件自动生成了类及构造函数。

把类放到一个命名空间tooloptions中。（其他文件可以调用，命名空间不可以与内部的类名相同）



```
using System;
using System.Windows.Forms;


namespace tooloptions
{
    public partial class Options :Form
    {
        private Button button1;
        private Button button3;

        public Options()
        {
            InitializeComponent();
        }


        #region Windows 窗体设计器生成的代码


        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.ClientSize = new System.Drawing.Size(558, 412);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }
        #endregion

    }
}


```

InitializeComponent方法是设计器自动生成的方法。

添加region对，说明这些代码是 Windows 窗体设计器生成的代码

双击菜单栏中的【工具】——【配置】，则跳转到对应的代码，在代码中添加如下代码

```

        private void 选项OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 创建新窗体实例
            Options myForm = new Options();
            // 显示新窗体
            myForm.Show();
        }
```

在【解决方案资源管理器】中双击Options.cs，则进入到Options.cs设计窗口。如查看代码则Options.cs上右键选择【查看代码】





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





















