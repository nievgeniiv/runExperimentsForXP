// Static Model


#ifndef __ISETTINGCONTROLLER__
#define __ISETTINGCONTROLLER__


// Include files
#include "IPairIterator.h"
#include "ISettingEnum.h"
#include "ISettingRect.h"
#include "ISettingScalar.h"

namespace VsCoreLib
{
  
  class ITunerSettingEnum
  {
  public:
    virtual void SetValues(IPairIterator* it)=0;
  };

  class ITunerSettingScalar
  {
  public:
    virtual void SetUnits(IPairIterator* it, int* minValues, int* maxValues)=0;
  };

  class ITunerSettingRect
  {
  public:
    virtual void SetMinRectangle(unsigned long x, unsigned long y,
      unsigned long w, unsigned long h)=0;
    virtual void SetMaxRectangle(unsigned long x, unsigned long y,
      unsigned long w, unsigned long h)=0;
  };

  class ISettingController
	{
	public:
    virtual void Apply(ISettingEnum* setting)=0;
    virtual void Update(ISettingEnum* setting)=0;
    virtual void Apply(ISettingScalar* setting)=0;
    virtual void Update(ISettingScalar* setting)=0;
    virtual void Apply(ISettingRect* setting)=0;
    virtual void Update(ISettingRect* setting)=0;
    virtual void SetTuner(ITunerSettingEnum* tuneIface)=0;
    virtual void SetTuner(ITunerSettingRect* tuneIface)=0;
    virtual void SetTuner(ITunerSettingScalar* tuneIface)=0;
	};// END INTERFACE DEFINITION ISettingController

} // VsCoreLib


#endif // __ISETTINGCONTROLLER__
