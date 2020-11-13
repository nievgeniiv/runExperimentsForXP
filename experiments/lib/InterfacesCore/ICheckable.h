#pragma once

//#include "IChecker.h"

namespace VsCoreLib {

  class IChecker;

  class ICheckable
  {
  public:
	  virtual void RegisterChecker(IChecker* checker) = 0;
  };

};