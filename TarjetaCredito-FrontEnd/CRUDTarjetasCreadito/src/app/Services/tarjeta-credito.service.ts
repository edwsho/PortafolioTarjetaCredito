import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tarjeta } from '../Models/tarjeta'

@Injectable({
  providedIn: 'root'
})
export class TarjetaCreditoService {

  private baseUrl =environment.baseUrl;

  constructor(private http: HttpClient) { }

  getAllTarjetas() : Observable<Tarjeta>{
    return this.http.get( this.baseUrl + "api/Tarjeta/GetTarjetas");
  }

}
