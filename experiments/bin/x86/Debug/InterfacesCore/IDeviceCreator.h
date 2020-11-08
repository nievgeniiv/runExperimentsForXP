// Static Model


#ifndef __IDEVICECREATOR__
#define __IDEVICECREATOR__


// Include files
#include "IDevice.h"
#include "ISettingIterator.h"

namespace VsCoreLib
{

	class IDeviceCreator
	{
	public:
    virtual ISettingIterator* __stdcall GetSystemSettings()=0;
		virtual IDevice* __stdcall Create()=0;
	};// END INTERFACE DEFINITION IDeviceCreator

} // VsCoreLib


#endif // __IDEVICECREATOR__
