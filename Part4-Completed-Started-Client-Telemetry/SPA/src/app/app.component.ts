import { Component } from '@angular/core';
import { LoggerService } from './logger.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'SPA';

  /**
   *
   */
  constructor(
             private _loggerService: LoggerService
  ) {
  

  }

  onClick(event: any)
  {
    this._loggerService.logEvent("Test App Insights");
  }
}
