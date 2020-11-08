//
// ISettingObserver.h

#ifndef __ISETTINGOBSERVER__
#define __ISETTINGOBSERVER__

namespace VsCoreLib
{

class ISetting;

class ISettingObserver
{
  public:
    virtual void __stdcall Update(ISetting* object)=0;
  };
}

#endif // __ISETTINGOBSERVER__

