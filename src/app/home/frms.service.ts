import { Injectable, Inject } from '@angular/core';
import { Http, RequestOptions, URLSearchParams, Headers, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/operator/delay';
import 'rxjs/operator/mergeMap';
import 'rxjs/operator/switchMap';
import { of } from 'rxjs/observable/of';
import { map, catchError } from 'rxjs/operators';


// https://stackoverflow.com/questions/40916707/cannot-convert-type-observableobject-to-type-observablecategoriesdata

import { HomeModel } from './home-model.interface';

@Injectable()
export class FrmsService {
    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) { }

    public getHomeModel(): Observable<HomeModel> {
        return this.http.get('http://localhost:60648/api/Frms/GetHomeModel').map(response => response.json() as HomeModel);
    }

    public getFilingRequests(): Observable<HomeModel> {
        return this.http.get(this.baseUrl + 'api/Data/GetFilingRequests').map(response => response.json() as HomeModel);
    }

    public getFilingRequest(filingRequestId: Number): Observable<HomeModel> {

        const urlSearchParams = new URLSearchParams();
        urlSearchParams.set('filingRequestId', filingRequestId.toString());

        const requestOptions = new RequestOptions();
        requestOptions.params = urlSearchParams;

        return this.http.get(this.baseUrl + 'api/Data/GetFilingRequest', requestOptions).map(response => response.json() as HomeModel);
    }
}
