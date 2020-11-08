//
// IFrameBufferObserver.h
//

#ifndef __IFRAMEBUFFEROBSERVER_H__
#define __IFRAMEBUFFEROBSERVER_H__

namespace VsCoreLib
{

  class IFrameBufferObserver
  {
  public:
    virtual void __stdcall NewFrame(unsigned int frameNumber)=0;
  };

}

#endif // __IFRAMEBUFFEROBSERVER_H__