// MathLibrary.h - �������к���������
#pragma once

#ifdef MATHLIBRARY_EXPORTS
#define MATHLIBRARY_API __declspec(dllexport)
#else
#define MATHLIBRARY_API __declspec(dllimport)
#endif

// �����ú�����ֱ�ӷ���1
extern "C" MATHLIBRARY_API int test();