
#include<Windows.h>



#define ID_BUTTON_OK 1001
#define ID_COMBOBOX 1001



HWND hButtonOK;
HWND hComboBox;
HWND hRichEdit;


// 定时器 ID
#define TIMER_ID 1

// 定时器间隔，单位为毫秒
#define TIMER_INTERVAL 1000
//
//extern "C"
//{
//    extern int cmain(void);
//}






// 1：表示红；2：表示绿； 3：表示蓝
unsigned char aoMenLiuHeSpecialCodeColor_Tab2021[] = {
	3, 3, 3, 1, 2, 1, 2, 1, 3, 1, 3, 3, 2, 3, 1, 1, 1, 2, 1, 1, 2, 1, 1, 2, 2, 1, 1, 2, 2, 3, 3, // 1月
	3, 3, 2, 2, 3, 2, 2, 2, 2, 3, 3, 3, 3, 2, 3, 2, 1, 2, 2, 2, 3, 2, 2, 2, 1, 3, 3, 2,          // 2月
	2, 1, 1, 3, 1, 2, 2, 3, 3, 3, 2, 2, 3, 2, 1, 3, 3, 2, 1, 2, 1, 1, 2, 2, 2, 3, 3, 3, 1, 1, 2, // 3月
	1, 3, 1, 1, 1, 1, 3, 2, 1, 2, 3, 2, 2, 1, 2, 1, 3, 1, 3, 3, 3, 1, 3, 1, 3, 2, 3, 2, 3, 1,    // 4月
	3, 1, 3, 1, 3, 1, 3, 3, 1, 2, 1, 1, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 2, 1, 1, 1, 1, 2, 2, 3, // 5月
	3, 3, 2, 3, 2, 3, 1, 2, 1, 3, 3, 3, 1, 1, 2, 2, 3, 1, 1, 1, 3, 1, 3, 3, 2, 3, 1, 2, 3, 2,    // 6月
	3, 2, 3, 1, 3, 1, 1, 2, 1, 1, 3, 2, 3, 2, 3, 2, 1, 3, 2, 3, 2, 1, 1, 3, 2, 3, 2, 1, 3, 1, 2, // 7月
	2, 2, 3, 3, 2, 2, 3, 2, 2, 3, 1, 3, 1, 2, 3, 3, 3, 3, 3, 3, 3, 2, 1, 1, 3, 2, 1, 3, 2, 2, 1, // 8月
	2, 2, 1, 3, 1, 1, 3, 2, 3, 1, 2, 1, 1, 3, 2, 2, 2, 1, 2, 3, 1, 1, 2, 1, 2, 2, 1, 2, 1, 2,    // 9月
	2, 2, 1, 1, 1, 2, 3, 1, 1, 3, 3, 3, 3, 1, 3, 2, 2, 1, 3, 1, 3, 2, 3, 2, 1, 3, 3, 3, 3, 3, 1, // 10月
	1, 2, 1, 2, 1, 3, 3, 2, 1, 3, 2, 3, 1, 3, 1, 2, 2, 2, 1, 2, 3, 2, 2, 1, 1, 2, 2, 3, 2, 3,    // 11月
	3, 1, 1, 1, 2, 3, 2, 1, 2, 1, 2, 2, 3, 1, 2, 3, 1, 3, 1, 3, 2, 2, 1, 2, 2, 2, 3, 1, 3, 2, 2  // 12月
};

// 1：表示红；2：表示绿； 3：表示蓝
unsigned char aoMenLiuHeSpecialCodeColor_Tab2022[] = {
	2, 2, 3, 3, 3, 2, 2, 2, 1, 3, 2, 2, 2, 2, 3, 2, 1, 2, 3, 1, 3, 3, 1, 1, 2, 3, 1, 1, 2, 1, 3, // 1月
	2, 3, 1, 2, 3, 2, 2, 3, 2, 1, 1, 2, 2, 2, 2, 1, 2, 3, 3, 1, 3, 2, 1, 1, 2, 1, 2, 2,          // 2月
	1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 2, 1, 3, 1, 1, 2, 1, 3, 1, 2, 2, 3, 1, 3, 2, 1, 1, 1, 2, 2, 2, // 3月
	2, 1, 3, 1, 1, 3, 1, 2, 1, 3, 2, 1, 2, 3, 2, 1, 3, 1, 2, 2, 3, 2, 3, 2, 2, 1, 2, 1, 2, 2,    // 4月
	3, 2, 2, 1, 3, 1, 3, 1, 3, 3, 1, 1, 2, 1, 3, 2, 3, 2, 2, 1, 2, 2, 1, 2, 2, 2, 3, 3, 3, 3, 2, // 5月
	3, 2, 1, 1, 1, 2, 1, 3, 3, 1, 2, 1, 2, 1, 3, 3, 1, 1, 2, 2, 1, 1, 3, 3, 3, 3, 3, 1, 2, 2,    // 6月
	3, 3, 1, 3, 3, 2, 1, 1, 3, 3, 1, 3, 1, 3, 1, 1, 1, 1, 2, 1, 2, 1, 2, 2, 1, 1, 1, 3, 1, 2, 2, // 7月
	3, 3, 3, 3, 3, 1, 3, 3, 3, 1, 3, 1, 3, 3, 2, 1, 2, 3, 3, 2, 3, 3, 3, 3, 2, 3, 2, 2, 2, 2, 2, // 8月
	3, 1, 1, 3, 3, 1, 2, 2, 3, 2, 2, 3, 1, 1, 1, 2, 1, 1, 3, 1, 2, 2, 1, 3, 3, 2, 3, 1, 1, 3,    // 9月
	3, 1, 1, 3, 3, 3, 1, 2, 2, 1, 1, 3, 3, 2, 3, 1, 1, 1, 3, 2, 2, 3, 3, 2, 2, 3, 3, 3, 2, 1, 1, // 10月
	3, 2, 1, 3, 2, 1, 3, 1, 3, 3, 3, 2, 2, 2, 3, 2, 2, 2, 2, 1, 1, 2, 2, 1, 3, 2, 1, 3, 1, 1,    // 11月
	3, 1, 2, 3, 1, 2, 1, 3, 3, 2, 3, 3, 3, 1, 3, 2, 3, 3, 1, 3, 1, 1, 1, 3, 3, 1, 3, 1, 2, 2, 2  // 12月
};




//我们关闭一个程序时是发送WM_CLOSE消息(函数SendMessage ? )，然后调用DestroyWindow函数，调用DestroyWindow时系统会向程序发WM_DESTROY消息，终止整个程序。

// 窗口消息处理函数
LRESULT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_CREATE:
		// 创建定时器
		//SetTimer(hwnd, TIMER_ID, TIMER_INTERVAL, TimerProc);
		break;

	case WM_TIMER:
		// 处理定时器消息
		if (wParam == TIMER_ID)
		{
			//TimerProc(hwnd, uMsg, wParam, lParam);
		}
		break;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case ID_BUTTON_OK:
			// 处理按钮点击事件
			OutputDebugString(L"BUTTON OK\n");
			break;
		}
		break;

	case WM_DESTROY:

		OutputDebugString(L"Application started!\n");
		
		PostQuitMessage(0);
		break;

		//WM_CLOSE是在窗口关闭前发送的，你还可以决定是否真的关闭窗口
	case WM_CLOSE:
		/*break;*/


	default:
		return DefWindowProc(hwnd, uMsg, wParam, lParam);
	}

	return 0;
}


int WINAPI WinMain(
	_In_ HINSTANCE hInstance,      // handle to current instance当前应用程序句柄
	_In_opt_ HINSTANCE hPrevInstance,  // handle to previous instance前一个实例句柄
	_In_ LPSTR lpCmdLine,          // command line命令行参数
	_In_ int nCmdShow              // show state窗口的显示方式：最大化、全屏、最小化、
)
{

	MessageBox(NULL, //父窗口句柄
		L"我是谁", L"提示", MB_OK); //弹出一个消息框
	// 创建窗口类
	WNDCLASS wc = {};
	wc.lpfnWndProc = WndProc;
	wc.hInstance = hInstance;
	wc.lpszClassName = L"TimerWindow";
	RegisterClass(&wc);

	// 创建窗口
	HWND hwnd = CreateWindowW(
		L"TimerWindow",
		L"深圳市伟深伊能科技有限公司",
		WS_OVERLAPPEDWINDOW | WS_SYSMENU | WS_THICKFRAME,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		NULL, NULL, hInstance, NULL);


	//创建一个按键
	hButtonOK = CreateWindowExW(
		0,
		L"BUTTON",
		L"OK",
		WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
		10, 10, 80, 30, //基于父窗口中的坐标XY，窗口的大小
		hwnd,   //父窗口句柄
		(HMENU)ID_BUTTON_OK,
		GetModuleHandle(NULL),
		NULL);

	hComboBox = CreateWindowEx(
		0, 
		L"COMBOBOX",
		NULL, 
		WS_CHILD | WS_VISIBLE | CBS_DROPDOWNLIST,
		100, 10, 150, 150,
		hwnd,   //父窗口句柄
		(HMENU)ID_COMBOBOX, 
		GetModuleHandle(NULL),
		NULL);

	hRichEdit = CreateWindowEx(
		WS_EX_CLIENTEDGE,
		L"RichEdit",
		NULL,
		WS_CHILD | WS_VISIBLE | ES_MULTILINE | ES_AUTOVSCROLL | ES_READONLY,
		10, 50, 100, 200,
		hwnd,   //父窗口句柄
		NULL, 
		GetModuleHandle(NULL),//hInstance, 
		NULL);

	// 显示窗口
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);

	// 消息循环
	MSG msg = {};
	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return 0;
}

