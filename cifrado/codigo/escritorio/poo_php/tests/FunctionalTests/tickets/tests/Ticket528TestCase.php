<?php

class Ticket528TestCase extends PradoGenericSelenium2Test
{
	function test()
	{
		$base = 'ctl0_Content_';
		$this->url('tickets/index.php?page=Ticket528');
		$this->assertEquals($this->title(), "Verifying Ticket 528");

		$this->select("{$base}DDropTurno", "Tarde");
		$this->pause(800);

		$this->assertValue("{$base}Codigo", "T");
		$this->assertValue("{$base}Descricao", "Tarde");

		$this->select("{$base}DDropTurno", "Manhã");
		$this->pause(800);

		$this->assertValue("{$base}Codigo", "M");
		$this->assertValue("{$base}Descricao", "Manhã");

		$this->select("{$base}DDropTurno", "Noite");
		$this->pause(800);

		$this->assertValue("{$base}Codigo", "N");
		$this->assertValue("{$base}Descricao", "Noite");

	}
}
