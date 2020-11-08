// Static Model


#ifndef __ISETTINGENUM__
#define __ISETTINGENUM__


// Include files
#include "IPairIterator.h"

namespace VsCoreLib
{

	class ISettingEnum
	{
	public:
		virtual IPairIterator* __stdcall GetValues()=0;
		virtual unsigned int __stdcall GetValueID() const=0;
		virtual void __stdcall SetValueID(unsigned int val)=0;
	};
  // END INTERFACE DEFINITION ISettingEnum

} // VsCoreLib


#endif // __ISETTINGENUM__

