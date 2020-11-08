// Static Model


#ifndef __ISETTINGSCALAR__
#define __ISETTINGSCALAR__


// Include files
#include "IPairIterator.h"

namespace VsCoreLib
{

	class ISettingScalar
	{
	public:
		virtual IPairIterator* __stdcall GetUnits()=0;
		virtual signed long __stdcall GetValue() const=0;
    virtual signed long __stdcall GetDelta() const=0;
    virtual unsigned int __stdcall GetUnit() const=0;
		virtual void __stdcall SetValue(signed long val)=0;
		virtual void __stdcall SetRelative(signed long delta)=0;
		virtual void __stdcall SetUnit(unsigned int unit)=0;
		virtual signed long __stdcall GetMinimum(unsigned int unit)=0;
		virtual signed long __stdcall GetMaximum(unsigned int unit)=0;
  
	};// END INTERFACE DEFINITION ISettingScalar

} // VsCoreLib


#endif // __ISETTINGSCALAR__

