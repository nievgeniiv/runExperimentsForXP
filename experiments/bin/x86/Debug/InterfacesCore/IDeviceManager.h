// Static Model


#ifndef __IDEVICEMANAGER__
#define __IDEVICEMANAGER__


// Include files
#include "IDeviceCreator.h"
#include "IPair.h"
#include "IPairIterator.h"

namespace VsCoreLib
{
	
  class IDeviceManager
	{
	public:
		virtual void __stdcall Initialize()=0;
		virtual IPairIterator* __stdcall GetDevicePrototypes()=0;
		virtual IDeviceCreator* __stdcall GetDeviceCreator(IPair* proto)=0;
		virtual IDevice* __stdcall GetDevice(IPair* proto)=0;
	};// END INTERFACE DEFINITION IDeviceManager

} // VsCoreLib


#endif // __IDEVICEMANAGER__

/*
//
// IDeviceManager.h
//

#pragma once

#include "IDeviceList.h"

namespace VsCoreLib_v4 
{

	class IDeviceManager
	{
  public:
    virtual ~IDeviceManager() = 0 {}
	public:
		virtual IDeviceList* GetDeviceList() = 0;
		virtual void Initialize() = 0;
	};

}
*/