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

int main()
{

	char strTime[128];

	
	FILETIME system_time;
	SYSTEMTIME sys_time;
	GetSystemTimeAsFileTime(&system_time);
	FileTimeToSystemTime(&system_time, &sys_time);

	sprintf_s(strTime,
		"%d-%d-%d  %d:%d:%d",
		sys_time.wYear,
		sys_time.wMonth,
		sys_time.wDay,
		sys_time.wHour,
		sys_time.wMinute,
		sys_time.wSecond);

	std::cout << strTime;

	std::cout << "Hello World!\n";

	


	window = CreateWindowEx(0, WC_DIALOG, L"Form example", WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, 640, 480, nullptr, nullptr, nullptr, nullptr);
	//button = CreateWindowEx(0, WC_BUTTON, L"Close", WS_CHILD | WS_VISIBLE, 10, 10, 75, 25, window, nullptr, nullptr, nullptr);

	//defWndProc = (WNDPROC)SetWindowLongPtr(window, GWLP_WNDPROC, (LONG_PTR)WndProc);

	ShowWindow(window, SW_SHOW);

	MSG message = { 0 };
	while (GetMessage(&message, nullptr, 0, 0))
		DispatchMessage(&message);
	return (int)message.wParam;



	//在设备的指定位置绘制一个颜色为crColor的像素点，这样就可以画直线画长方形画心，然后就可以画漂亮的小姐姐了
	//COLORREF SetPixel(HDC hdc, int X, int Y, COLORREF crColor)

	//CreateWindow()


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
