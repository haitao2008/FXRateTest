import { Component } from '@angular/core';
import { FXDataService } from './fx-data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  constructor(private fxService: FXDataService) { }

  fxData: FXRateModel[];

  ngOnInit() {

    this.refresh()

  }

  refresh() {
    this.fxService.getFXdata().subscribe(x => {
      this.fxData = x;
    })
  }
}
