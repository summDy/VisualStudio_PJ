// ConsoleApplication1.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
#include <Windows.h>

extern "C" {
#include <stdio.h>
#include <string.h>
}



HWND window = nullptr;
HWND button = nullptr;
WNDPROC defWndProc = nullptr;





LRESULT CALLBACK  WndProc(HWND, UINT, WPARAM, LPARAM);
void OnSize(HWND hwnd, UINT flag, int width, int height);



//主线程
DWORD WINAPI mainThread(__in LPVOID lpParameter)
{
	std::cout << "Hello mainThread!\n";
	return 0;

}

//
void demo_thread(void) 
{

}

static SYSTEMTIME sysTimeTe(void)
{
	FILETIME system_time;
	SYSTEMTIME sys_time;
	GetSystemTimeAsFileTime(&system_time);
	FileTimeToSystemTime(&system_time, &sys_time);

	return sys_time;
}

static void windowTe(void)
{


	WNDCLASS wndclass;

	wndclass.style = CS_HREDRAW | CS_VREDRAW;
	wndclass.lpfnWndProc = WndProc;
	wndclass.cbClsExtra = 0;
	wndclass.cbWndExtra = 0;
	wndclass.hbrBackground = (HBRUSH)GetStockObject(BLACK_BRUSH);
	//wndclass.hInstance = hInstance;
	wndclass.hCursor = LoadCursor(NULL, IDC_ARROW);
	wndclass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	//wndclass.lpszClassName = szAppName;
	wndclass.lpszMenuName = NULL;

	//RegisterClass 函数向操作系统注册窗口类。
	if (!RegisterClass(&wndclass))
	{
		//MessageBox(NULL, TEXT("This program requires windows NT!"), szAppName, MB_ICONERROR);
		//return 0;
	}

	window = CreateWindowEx(
		0,					//允许为窗口指定一些可选行为（例如透明窗口），对于默认行为设为0
		WC_DIALOG,			//window class
		L"Form example",	//window text 
		WS_OVERLAPPEDWINDOW, //window style

		//size and position
		CW_USEDEFAULT, CW_USEDEFAULT, 640, 480, 

		nullptr, //parent window
		nullptr, 
		nullptr, 
		nullptr);
	//button = CreateWindowEx(0, WC_BUTTON, L"Close", WS_CHILD | WS_VISIBLE, 10, 10, 75, 25, window, nullptr, nullptr, nullptr);

	//defWndProc = (WNDPROC)SetWindowLongPtr(window, GWLP_WNDPROC, (LONG_PTR)WndProc);
	//SetPixel(100, 200, )
	ShowWindow(window, SW_SHOW);
	UpdateWindow(window);
}





//程序入口
int main(int argc, char* argv[])
{

	char strTime[128];
	HANDLE mainHandle;
	DWORD mythreadid;

	
	FILETIME system_time;
	SYSTEMTIME sys_time;
	GetSystemTimeAsFileTime(&system_time);
	FileTimeToSystemTime(&system_time, &sys_time);
	sys_time = sysTimeTe();

	sprintf_s(strTime,
		"%d-%d-%d  %d:%d:%d",
		sys_time.wYear,
		sys_time.wMonth,
		sys_time.wDay,
		sys_time.wHour,
		sys_time.wMinute,
		sys_time.wSecond);

	std::cout << strTime;

	std::cout << "\nHello World!\n";


	mainHandle = CreateThread(NULL, NULL, mainThread, 0, 0, &mythreadid);
	

	
	/*MSG message = { 0 };
	while (GetMessage(&message, nullptr, 0, 0))
		DispatchMessage(&message);
	return (int)message.wParam;*/

	//在设备的指定位置绘制一个颜色为crColor的像素点，这样就可以画直线画长方形画心，然后就可以画漂亮的小姐姐了
	//COLORREF SetPixel(HDC hdc, int X, int Y, COLORREF crColor)

}

// 运行程序: Ctrl + F5 或调试 >“开始执行(不调试)”菜单
// 调试程序: F5 或调试 >“开始调试”菜单

// 入门使用技巧: 
//   1. 使用解决方案资源管理器窗口添加/管理文件
//   2. 使用团队资源管理器窗口连接到源代码管理
//   3. 使用输出窗口查看生成输出和其他消息
//   4. 使用错误列表窗口查看错误
//   5. 转到“项目”>“添加新项”以创建新的代码文件，或转到“项目”>“添加现有项”以将现有代码文件添加到项目
//   6. 将来，若要再次打开此项目，请转到“文件”>“打开”>“项目”并选择 .sln 文件









LRESULT CALLBACK WndProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	static int cxClient, cyClient;
	HDC  hdc;
	PAINTSTRUCT ps;
	int i;

	switch (message)
	{
	case WM_CREATE:
		cxClient = LOWORD(lParam);
		cyClient = HIWORD(lParam);
		return 0;
	case  WM_PAINT:
		hdc = BeginPaint(hwnd, &ps);
		//for (i = 0; i < 800; i += cxClient)
			SetPixel(hdc, i, i, RGB(255, 0, 0));
		EndPaint(hwnd, &ps);
	case  WM_DESTROY:
		PostQuitMessage(0);
		return 0;
	}
	return DefWindowProc(hwnd, message, wParam, lParam);

}




LRESULT CALLBACK WindowProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_SIZE:
	{
		int width = LOWORD(lParam);  // Macro to get the low-order word.
		int height = HIWORD(lParam); // Macro to get the high-order word.

		// Respond to the message:
		OnSize(hwnd, (UINT)wParam, width, height);
	}
	break;
	}
}

void OnSize(HWND hwnd, UINT flag, int width, int height)
{
	// Handle resizing
}
