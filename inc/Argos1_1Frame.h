#ifndef _ARGOS_1___1_FRAME_H_
#define _ARGOS_1___1_FRAME_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class Argos1_1Frame
	: public Tizen::Ui::Controls::Frame
{
public:
	Argos1_1Frame(void);
	virtual ~Argos1_1Frame(void);

private:
	virtual result OnInitializing(void);
	virtual result OnTerminating(void);
};

#endif	//_ARGOS_1___1_FRAME_H_
