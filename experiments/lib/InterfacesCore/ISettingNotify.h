// Static Model


#ifndef __ISETTINGNOTIFY__
#define __ISETTINGNOTIFY__

namespace VsCoreLib
{
  
  class ISettingNotify
  {
  public:
    virtual void __stdcall NotifyObserver()=0;
  };

} // VsCoreLib


#endif // __ISETTINGNOTIFY__
