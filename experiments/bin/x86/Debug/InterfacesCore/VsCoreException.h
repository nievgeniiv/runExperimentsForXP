//
// VsCoreException.h
//

#ifndef __VSCOREEXCEPTION_H__
#define __VSCOREEXCEPTION_H__

namespace VsCoreLib
{

  class VsCoreException
  {
  public:
    VsCoreException() {}
    virtual ~VsCoreException() = 0 {}

  public:
    virtual const char* GetErrDescription() const = 0;
  };

}

#endif // __VSCOREEXCEPTION_H__