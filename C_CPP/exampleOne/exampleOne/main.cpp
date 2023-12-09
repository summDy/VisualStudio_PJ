
#include<Windows.h>



#define ID_BUTTON_OK 1001
#define ID_COMBOBOX 1001



HWND hButtonOK;
HWND hComboBox;
HWND hRichEdit;


// ��ʱ�� ID
#define TIMER_ID 1

// ��ʱ���������λΪ����
#define TIMER_INTERVAL 1000
//
//extern "C"
//{
//    extern int cmain(void);
//}






// 1����ʾ�죻2����ʾ�̣� 3����ʾ��
unsigned char aoMenLiuHeSpecialCodeColor_Tab2021[] = {
	3, 3, 3, 1, 2, 1, 2, 1, 3, 1, 3, 3, 2, 3, 1, 1, 1, 2, 1, 1, 2, 1, 1, 2, 2, 1, 1, 2, 2, 3, 3, // 1��
	3, 3, 2, 2, 3, 2, 2, 2, 2, 3, 3, 3, 3, 2, 3, 2, 1, 2, 2, 2, 3, 2, 2, 2, 1, 3, 3, 2,          // 2��
	2, 1, 1, 3, 1, 2, 2, 3, 3, 3, 2, 2, 3, 2, 1, 3, 3, 2, 1, 2, 1, 1, 2, 2, 2, 3, 3, 3, 1, 1, 2, // 3��
	1, 3, 1, 1, 1, 1, 3, 2, 1, 2, 3, 2, 2, 1, 2, 1, 3, 1, 3, 3, 3, 1, 3, 1, 3, 2, 3, 2, 3, 1,    // 4��
	3, 1, 3, 1, 3, 1, 3, 3, 1, 2, 1, 1, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 2, 1, 1, 1, 1, 2, 2, 3, // 5��
	3, 3, 2, 3, 2, 3, 1, 2, 1, 3, 3, 3, 1, 1, 2, 2, 3, 1, 1, 1, 3, 1, 3, 3, 2, 3, 1, 2, 3, 2,    // 6��
	3, 2, 3, 1, 3, 1, 1, 2, 1, 1, 3, 2, 3, 2, 3, 2, 1, 3, 2, 3, 2, 1, 1, 3, 2, 3, 2, 1, 3, 1, 2, // 7��
	2, 2, 3, 3, 2, 2, 3, 2, 2, 3, 1, 3, 1, 2, 3, 3, 3, 3, 3, 3, 3, 2, 1, 1, 3, 2, 1, 3, 2, 2, 1, // 8��
	2, 2, 1, 3, 1, 1, 3, 2, 3, 1, 2, 1, 1, 3, 2, 2, 2, 1, 2, 3, 1, 1, 2, 1, 2, 2, 1, 2, 1, 2,    // 9��
	2, 2, 1, 1, 1, 2, 3, 1, 1, 3, 3, 3, 3, 1, 3, 2, 2, 1, 3, 1, 3, 2, 3, 2, 1, 3, 3, 3, 3, 3, 1, // 10��
	1, 2, 1, 2, 1, 3, 3, 2, 1, 3, 2, 3, 1, 3, 1, 2, 2, 2, 1, 2, 3, 2, 2, 1, 1, 2, 2, 3, 2, 3,    // 11��
	3, 1, 1, 1, 2, 3, 2, 1, 2, 1, 2, 2, 3, 1, 2, 3, 1, 3, 1, 3, 2, 2, 1, 2, 2, 2, 3, 1, 3, 2, 2  // 12��
};

// 1����ʾ�죻2����ʾ�̣� 3����ʾ��
unsigned char aoMenLiuHeSpecialCodeColor_Tab2022[] = {
	2, 2, 3, 3, 3, 2, 2, 2, 1, 3, 2, 2, 2, 2, 3, 2, 1, 2, 3, 1, 3, 3, 1, 1, 2, 3, 1, 1, 2, 1, 3, // 1��
	2, 3, 1, 2, 3, 2, 2, 3, 2, 1, 1, 2, 2, 2, 2, 1, 2, 3, 3, 1, 3, 2, 1, 1, 2, 1, 2, 2,          // 2��
	1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 2, 1, 3, 1, 1, 2, 1, 3, 1, 2, 2, 3, 1, 3, 2, 1, 1, 1, 2, 2, 2, // 3��
	2, 1, 3, 1, 1, 3, 1, 2, 1, 3, 2, 1, 2, 3, 2, 1, 3, 1, 2, 2, 3, 2, 3, 2, 2, 1, 2, 1, 2, 2,    // 4��
	3, 2, 2, 1, 3, 1, 3, 1, 3, 3, 1, 1, 2, 1, 3, 2, 3, 2, 2, 1, 2, 2, 1, 2, 2, 2, 3, 3, 3, 3, 2, // 5��
	3, 2, 1, 1, 1, 2, 1, 3, 3, 1, 2, 1, 2, 1, 3, 3, 1, 1, 2, 2, 1, 1, 3, 3, 3, 3, 3, 1, 2, 2,    // 6��
	3, 3, 1, 3, 3, 2, 1, 1, 3, 3, 1, 3, 1, 3, 1, 1, 1, 1, 2, 1, 2, 1, 2, 2, 1, 1, 1, 3, 1, 2, 2, // 7��
	3, 3, 3, 3, 3, 1, 3, 3, 3, 1, 3, 1, 3, 3, 2, 1, 2, 3, 3, 2, 3, 3, 3, 3, 2, 3, 2, 2, 2, 2, 2, // 8��
	3, 1, 1, 3, 3, 1, 2, 2, 3, 2, 2, 3, 1, 1, 1, 2, 1, 1, 3, 1, 2, 2, 1, 3, 3, 2, 3, 1, 1, 3,    // 9��
	3, 1, 1, 3, 3, 3, 1, 2, 2, 1, 1, 3, 3, 2, 3, 1, 1, 1, 3, 2, 2, 3, 3, 2, 2, 3, 3, 3, 2, 1, 1, // 10��
	3, 2, 1, 3, 2, 1, 3, 1, 3, 3, 3, 2, 2, 2, 3, 2, 2, 2, 2, 1, 1, 2, 2, 1, 3, 2, 1, 3, 1, 1,    // 11��
	3, 1, 2, 3, 1, 2, 1, 3, 3, 2, 3, 3, 3, 1, 3, 2, 3, 3, 1, 3, 1, 1, 1, 3, 3, 1, 3, 1, 2, 2, 2  // 12��
};




//���ǹر�һ������ʱ�Ƿ���WM_CLOSE��Ϣ(����SendMessage ? )��Ȼ�����DestroyWindow����������DestroyWindowʱϵͳ�������WM_DESTROY��Ϣ����ֹ��������

// ������Ϣ������
LRESULT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_CREATE:
		// ������ʱ��
		//SetTimer(hwnd, TIMER_ID, TIMER_INTERVAL, TimerProc);
		break;

	case WM_TIMER:
		// ����ʱ����Ϣ
		if (wParam == TIMER_ID)
		{
			//TimerProc(hwnd, uMsg, wParam, lParam);
		}
		break;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case ID_BUTTON_OK:
			// ����ť����¼�
			OutputDebugString(L"BUTTON OK\n");
			break;
		}
		break;

	case WM_DESTROY:

		OutputDebugString(L"Application started!\n");
		
		PostQuitMessage(0);
		break;

		//WM_CLOSE���ڴ��ڹر�ǰ���͵ģ��㻹���Ծ����Ƿ���Ĺرմ���
	case WM_CLOSE:
		/*break;*/


	default:
		return DefWindowProc(hwnd, uMsg, wParam, lParam);
	}

	return 0;
}


int WINAPI WinMain(
	_In_ HINSTANCE hInstance,      // handle to current instance��ǰӦ�ó�����
	_In_opt_ HINSTANCE hPrevInstance,  // handle to previous instanceǰһ��ʵ�����
	_In_ LPSTR lpCmdLine,          // command line�����в���
	_In_ int nCmdShow              // show state���ڵ���ʾ��ʽ����󻯡�ȫ������С����
)
{

	MessageBox(NULL, //�����ھ��
		L"����˭", L"��ʾ", MB_OK); //����һ����Ϣ��
	// ����������
	WNDCLASS wc = {};
	wc.lpfnWndProc = WndProc;
	wc.hInstance = hInstance;
	wc.lpszClassName = L"TimerWindow";
	RegisterClass(&wc);

	// ��������
	HWND hwnd = CreateWindowW(
		L"TimerWindow",
		L"������ΰ�����ܿƼ����޹�˾",
		WS_OVERLAPPEDWINDOW | WS_SYSMENU | WS_THICKFRAME,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		NULL, NULL, hInstance, NULL);


	//����һ������
	hButtonOK = CreateWindowExW(
		0,
		L"BUTTON",
		L"OK",
		WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
		10, 10, 80, 30, //���ڸ������е�����XY�����ڵĴ�С
		hwnd,   //�����ھ��
		(HMENU)ID_BUTTON_OK,
		GetModuleHandle(NULL),
		NULL);

	hComboBox = CreateWindowEx(
		0, 
		L"COMBOBOX",
		NULL, 
		WS_CHILD | WS_VISIBLE | CBS_DROPDOWNLIST,
		100, 10, 150, 150,
		hwnd,   //�����ھ��
		(HMENU)ID_COMBOBOX, 
		GetModuleHandle(NULL),
		NULL);

	hRichEdit = CreateWindowEx(
		WS_EX_CLIENTEDGE,
		L"RichEdit",
		NULL,
		WS_CHILD | WS_VISIBLE | ES_MULTILINE | ES_AUTOVSCROLL | ES_READONLY,
		10, 50, 100, 200,
		hwnd,   //�����ھ��
		NULL, 
		GetModuleHandle(NULL),//hInstance, 
		NULL);

	// ��ʾ����
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);

	// ��Ϣѭ��
	MSG msg = {};
	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return 0;
}

