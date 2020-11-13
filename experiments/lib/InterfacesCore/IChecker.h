#pragma once

namespace VsCoreLib_v4 {

  class Setting;

  class IChecker
  {
  public:
	  virtual void Check(Setting* setting) = 0;
  };

};