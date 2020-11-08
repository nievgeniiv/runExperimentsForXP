//
// IFrameEventListener.h
// Declaration of IFrameEventListener
//

#ifndef __IFRAMEVENTLISTENER_H__
#define __IFRAMEVENTLISTENER_H__

namespace VsCoreLib
{

class IFrameEventListener
{
public:
  virtual void ProcessFrame(LONG width, LONG height, LONG bits,
    short* pBuffer)=0;
};

}

#endif //__IFRAMEVENTLISTENER_H__