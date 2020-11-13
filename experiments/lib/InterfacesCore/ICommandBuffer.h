#pragma once

#include "../VsCoreLib/Setting.h"

namespace VsCoreLib_v4 {

  class ICommandBuffer
  {
  public:
    virtual bool Lock(int Direction, int TimeoutMs) = 0;
    virtual void Unlock() = 0;
    virtual void Write(int Id) = 0;
    virtual int Read(void) = 0;
  };

};