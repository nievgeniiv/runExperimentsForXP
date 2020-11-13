// Static Model


#ifndef __ISETTINGTUNER__
#define __ISETTINGTUNER__


// Include files
#include "IPairIterator.h"
#include "ISettingNotify.h"

namespace VsCoreLib
{
  
  class ISettingEnumTuner
  {
  public:
    virtual void AddValues(IPairIterator* it)=0;
    virtual void AddValue(unsigned initId, unsigned int code)=0;
  };

  class ISettingScalarTuner
  {
  public:
    virtual void AddUnits(IPairIterator* it)=0;
    virtual void AddUnit(unsigned int initId)=0;
		virtual void SetMinimum(long val, unsigned int unit)=0;
		virtual void SetMaximum(long val, unsigned int unit)=0;
  };

  class ISettingRectTuner
  {
  public:
    virtual void SetMinRectangle(unsigned long x, unsigned long y,
      unsigned long w, unsigned long h)=0;
    virtual void SetMaxRectangle(unsigned long x, unsigned long y,
      unsigned long w, unsigned long h)=0;
  };


} // VsCoreLib


#endif // __ISETTINGTUNER__
