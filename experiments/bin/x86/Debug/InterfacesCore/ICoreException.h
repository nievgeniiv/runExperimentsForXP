//
// ICoreException.h
//

#ifndef __ICOREEXCEPTION_H__
#define __ICOREEXCEPTION_H__

namespace VsCoreLib
{

class ErrorLevel
{
public:
  static const int HARD = -1;
  static const int MID  = 0;
  static const int EASY = 1;
};

class ICoreException
{
public:
  virtual const wchar_t* GetErrInfo() const = 0;
  virtual int GetErrLevel() const = 0;
};

}

#endif // __ICOREEXCEPTION_H__