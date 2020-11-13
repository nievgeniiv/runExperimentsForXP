// Static Model


#ifndef __ISETTINGRECT__
#define __ISETTINGRECT__


namespace VsCoreLib
{
	
  class ISettingRect
	{
	public:

		virtual void GetRectangle(unsigned long* x,
							unsigned long* y,
							unsigned long* w,
							unsigned long* h) const=0;
		virtual void SetRectangle(unsigned long x,
							unsigned long y,
							unsigned long w,
							unsigned long h)=0;
		virtual void GetMaximum(unsigned long* w,
						  unsigned long* h) const=0;
		virtual void GetMaximumRelatedXY(unsigned long* w,
								   unsigned long* h) const=0;
		virtual bool IsCentered() const=0;
		virtual bool IsFullWidth() const=0;
		virtual bool IsFullHeight() const=0;
		virtual void SetCentered(bool val)=0;
		virtual void SetFullWidth(bool val)=0;
		virtual void SetFullHeight(bool val)=0;
		virtual unsigned long GetX() const=0;
		virtual unsigned long GetY() const=0;
		virtual unsigned long GetWidth() const=0;
		virtual unsigned long GetHeight() const=0;
		virtual void SetX(unsigned long val)=0;
		virtual void SetY(unsigned long val)=0;
		virtual void SetWidth(unsigned long val)=0;
		virtual void SetHeight(unsigned long val)=0;

	};// END INTERFACE DEFINITION ISettingRect

} // VsCoreLib


#endif // __ISETTINGRECT__

