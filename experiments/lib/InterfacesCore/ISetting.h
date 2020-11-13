// Static Model


#ifndef __ISETTING__
#define __ISETTING__


// Include files
#include "ISettingEnum.h"
#include "ISettingRect.h"
#include "ISettingScalar.h"
#include "ISettingString.h"
#include "ISettingObserver.h"

namespace VsCoreLib
{

  class ISetting
	{
	public:
		virtual unsigned int __stdcall GetID() const=0;
		virtual unsigned int __stdcall GetTypeID() const=0;
		virtual unsigned int __stdcall GetGroupID() const=0;
		virtual const wchar_t* __stdcall GetName() const=0;
		virtual const wchar_t* __stdcall GetDescriptionShort() const=0;
		virtual const wchar_t* __stdcall GetDescriptionLong() const=0;
    virtual bool __stdcall isEnable()=0;
		virtual ISettingEnum* __stdcall EnumObj()=0;
		virtual ISettingRect* __stdcall RectObj()=0;
		virtual ISettingScalar* __stdcall ScalarObj()=0;
		virtual ISettingString* __stdcall StringObj()=0;
    virtual void __stdcall RegisterObserver(ISettingObserver* obeserver)=0;
    virtual void __stdcall UnregisterObserver(ISettingObserver* observer)=0;
	};

}


#endif
