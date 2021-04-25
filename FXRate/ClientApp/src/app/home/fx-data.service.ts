import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class FXDataService {

  constructor(private http: HttpClient) { }

  fxRate: FXRateModel[];

  getFXdata(): Observable<FXRateModel[]> {
    return this.http.get<FXRateModel[]>('FX' + '/GetFXRate');
  }


  
}


